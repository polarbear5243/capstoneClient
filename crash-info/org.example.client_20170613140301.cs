S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 16099
Date: 2017-06-13 14:03:01+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb277d64e

Register Information
r0   = 0xb814bd50, r1   = 0xb8147c88
r2   = 0xb8147c88, r3   = 0xb814bd50
r4   = 0xb3f6ca3c, r5   = 0xbed3e484
r6   = 0x00000001, r7   = 0xbed3e348
r8   = 0xbed3e478, r9   = 0xb7fa4e88
r10  = 0xbed3e498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbed3e2ec
lr   = 0xb277d5d5, pc   = 0xb277d64e
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     73392 KB
Buffers:     62392 KB
Cached:     226116 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19560 KB
VmRSS:       19560 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16099 TID = 16099
16099 16113 16459 16464 

Maps Information
b132e000 b1336000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1348000 b1b47000 rw-p [stack:16464]
b1b47000 b1b48000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b58000 b1b6c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b80000 b1b81000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b91000 b1b94000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1ba5000 b1ba6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bb6000 b1bb8000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bc8000 b1bca000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bda000 b1bea000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bfa000 b1c06000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c18000 b2417000 rw-p [stack:16459]
b2748000 b274f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2762000 b2768000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2778000 b27a8000 r-xp /opt/usr/apps/org.example.client/bin/client
b28f1000 b29d4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a0b000 b2a33000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a45000 b3244000 rw-p [stack:16113]
b3244000 b3246000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3256000 b3260000 r-xp /lib/libnss_files-2.20-2014.11.so
b3271000 b327a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b328b000 b329c000 r-xp /lib/libnsl-2.20-2014.11.so
b32af000 b32b5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32c6000 b32c7000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32ef000 b32f6000 r-xp /usr/lib/libminizip.so.1.0.0
b3306000 b330b000 r-xp /usr/lib/libstorage.so.0.1
b331b000 b337a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3390000 b33a4000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33b4000 b33f8000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3408000 b3410000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3420000 b3450000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3463000 b351c000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3530000 b3583000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3594000 b35af000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35bf000 b3680000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3693000 b36a3000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36b3000 b36c0000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36d1000 b36d8000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36e8000 b3729000 r-xp /usr/lib/libmdm.so.1.2.12
b3739000 b3741000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3750000 b3760000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3781000 b37e1000 r-xp /usr/lib/libasound.so.2.0.0
b37f3000 b37f6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3806000 b3809000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3819000 b381e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b382e000 b382f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b383f000 b384a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b385e000 b3865000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3875000 b387b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b388b000 b3890000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38a0000 b38bb000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38cb000 b38d2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38e2000 b38e5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38f6000 b3924000 r-xp /usr/lib/libidn.so.11.5.44
b3934000 b394a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b395b000 b3965000 r-xp /usr/lib/libcares.so.2.1.0
b3975000 b397f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b398f000 b3991000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39a1000 b39a2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39b2000 b39b6000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39c7000 b39ef000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a00000 b3a29000 r-xp /usr/lib/libturbojpeg.so
b3a49000 b3a4f000 r-xp /usr/lib/libgif.so.4.1.6
b3a5f000 b3aa5000 r-xp /usr/lib/libcurl.so.4.3.0
b3ab6000 b3ad7000 r-xp /usr/lib/libexif.so.12.3.3
b3af2000 b3b07000 r-xp /usr/lib/libtts.so
b3b18000 b3b20000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b30000 b3bf6000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c16000 b3d0e000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d2d000 b3dfb000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e12000 b3e14000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e24000 b3e2a000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e3a000 b3e5d000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e6e000 b3e70000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e80000 b3e82000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e93000 b3e98000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eaf000 b3eb1000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ec1000 b3ec8000 r-xp /usr/lib/libsensord-share.so
b3ed8000 b3ef0000 r-xp /usr/lib/libsensor.so.1.1.0
b3f01000 b3f04000 r-xp /usr/lib/libXv.so.1.0.0
b3f14000 b3f19000 r-xp /usr/lib/libutilX.so.1.1.0
b3f29000 b3f2e000 r-xp /usr/lib/libappcore-common.so.1.1
b3f3e000 b3f45000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f58000 b3f5c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f6d000 b404b000 r-xp /usr/lib/libCOREGL.so.4.0
b406b000 b406e000 r-xp /usr/lib/libuuid.so.1.3.0
b407e000 b4095000 r-xp /usr/lib/libblkid.so.1.1.0
b40a6000 b40a8000 r-xp /usr/lib/libXau.so.6.0.0
b40b8000 b40ff000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4111000 b4117000 r-xp /usr/lib/libjson-c.so.2.0.1
b4128000 b412c000 r-xp /usr/lib/libogg.so.0.7.1
b413c000 b415e000 r-xp /usr/lib/libvorbis.so.0.4.3
b416e000 b4252000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b426e000 b4271000 r-xp /usr/lib/libEGL.so.1.4
b4282000 b4288000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4298000 b429a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42aa000 b42b7000 r-xp /usr/lib/libGLESv2.so.2.0
b42c8000 b432a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b433f000 b4357000 r-xp /usr/lib/libmount.so.1.1.0
b4369000 b437d000 r-xp /usr/lib/libxcb.so.1.1.0
b438d000 b4394000 r-xp /lib/libcrypt-2.20-2014.11.so
b43cc000 b43ce000 r-xp /usr/lib/libiri.so
b43de000 b43e9000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43fa000 b4430000 r-xp /usr/lib/libpulse.so.0.16.2
b4441000 b4484000 r-xp /usr/lib/libsndfile.so.1.0.25
b4499000 b44ae000 r-xp /lib/libexpat.so.1.5.2
b44c0000 b457e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4592000 b459a000 r-xp /usr/lib/libdrm.so.2.4.0
b45aa000 b45ad000 r-xp /usr/lib/libdri2.so.0.0.0
b45bd000 b460b000 r-xp /usr/lib/libssl.so.1.0.0
b4620000 b462c000 r-xp /usr/lib/libeeze.so.1.13.0
b463d000 b4646000 r-xp /usr/lib/libethumb.so.1.13.0
b4656000 b4659000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4669000 b4820000 r-xp /usr/lib/libcrypto.so.1.0.0
b560b000 b5614000 r-xp /usr/lib/libXi.so.6.1.0
b5624000 b5626000 r-xp /usr/lib/libXgesture.so.7.0.0
b5636000 b563a000 r-xp /usr/lib/libXtst.so.6.1.0
b564a000 b5650000 r-xp /usr/lib/libXrender.so.1.3.0
b5660000 b5666000 r-xp /usr/lib/libXrandr.so.2.2.0
b5676000 b5678000 r-xp /usr/lib/libXinerama.so.1.0.0
b5689000 b568c000 r-xp /usr/lib/libXfixes.so.3.1.0
b569c000 b56a7000 r-xp /usr/lib/libXext.so.6.4.0
b56b7000 b56b9000 r-xp /usr/lib/libXdamage.so.1.1.0
b56c9000 b56cb000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56db000 b57bd000 r-xp /usr/lib/libX11.so.6.3.0
b57d1000 b57d8000 r-xp /usr/lib/libXcursor.so.1.0.2
b57e8000 b5800000 r-xp /usr/lib/libudev.so.1.6.0
b5802000 b5805000 r-xp /lib/libattr.so.1.1.0
b5815000 b5835000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5836000 b583b000 r-xp /usr/lib/libffi.so.6.0.2
b584c000 b5864000 r-xp /lib/libz.so.1.2.8
b5874000 b5876000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5886000 b595b000 r-xp /usr/lib/libxml2.so.2.9.2
b5970000 b5a0b000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a27000 b5a2a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a3a000 b5a53000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a64000 b5a75000 r-xp /lib/libresolv-2.20-2014.11.so
b5a89000 b5b03000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b18000 b5b1a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b2a000 b5b31000 r-xp /usr/lib/libembryo.so.1.13.0
b5b41000 b5b4b000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b5c000 b5b74000 r-xp /usr/lib/libpng12.so.0.50.0
b5b85000 b5ba8000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc9000 b5bdd000 r-xp /usr/lib/libector.so.1.13.0
b5bee000 b5c06000 r-xp /usr/lib/liblua-5.1.so
b5c17000 b5c6e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c82000 b5caa000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cbb000 b5cce000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cdf000 b5d19000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d2a000 b5d38000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d48000 b5d50000 r-xp /usr/lib/libtbm.so.1.0.0
b5d60000 b5d6d000 r-xp /usr/lib/libeio.so.1.13.0
b5d7d000 b5d7f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d8f000 b5d94000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5da4000 b5dbb000 r-xp /usr/lib/libefreet.so.1.13.0
b5dcd000 b5ded000 r-xp /usr/lib/libeldbus.so.1.13.0
b5dfd000 b5e1d000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e1f000 b5e25000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e35000 b5e46000 r-xp /usr/lib/libemotion.so.1.13.0
b5e57000 b5e5e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e6e000 b5e7d000 r-xp /usr/lib/libeo.so.1.13.0
b5e8e000 b5ea0000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eb1000 b5eb6000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ec6000 b5edf000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5eef000 b5f0c000 r-xp /usr/lib/libeet.so.1.13.0
b5f25000 b5f6d000 r-xp /usr/lib/libeina.so.1.13.0
b5f7e000 b5f8e000 r-xp /usr/lib/libefl.so.1.13.0
b5f9f000 b6084000 r-xp /usr/lib/libicuuc.so.51.1
b60a1000 b61e1000 r-xp /usr/lib/libicui18n.so.51.1
b61f8000 b6230000 r-xp /usr/lib/libecore_x.so.1.13.0
b6242000 b6245000 r-xp /lib/libcap.so.2.21
b6255000 b627e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b628f000 b6296000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62a8000 b62df000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62f0000 b63db000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63ee000 b6467000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6479000 b647e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b648e000 b6498000 r-xp /usr/lib/libvconf.so.0.2.45
b64a8000 b64aa000 r-xp /usr/lib/libvasum.so.0.3.1
b64ba000 b64bc000 r-xp /usr/lib/libttrace.so.1.1
b64cc000 b64cf000 r-xp /usr/lib/libiniparser.so.0
b64df000 b6505000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6515000 b651a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b652b000 b6542000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6553000 b65be000 r-xp /lib/libm-2.20-2014.11.so
b65cf000 b65d5000 r-xp /lib/librt-2.20-2014.11.so
b65e6000 b65f3000 r-xp /usr/lib/libunwind.so.8.0.1
b6629000 b674d000 r-xp /lib/libc-2.20-2014.11.so
b6762000 b677b000 r-xp /lib/libgcc_s-4.9.so.1
b678b000 b686d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b687e000 b68a8000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b9000 b68f5000 r-xp /usr/lib/libsystemd.so.0.4.0
b68f7000 b697a000 r-xp /usr/lib/libedje.so.1.13.0
b698d000 b69ab000 r-xp /usr/lib/libecore.so.1.13.0
b69cb000 b6b52000 r-xp /usr/lib/libevas.so.1.13.0
b6b87000 b6b9b000 r-xp /lib/libpthread-2.20-2014.11.so
b6baf000 b6de3000 r-xp /usr/lib/libelementary.so.1.13.0
b6e12000 b6e16000 r-xp /usr/lib/libsmack.so.1.0.0
b6e26000 b6e2d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e3d000 b6e3f000 r-xp /usr/lib/libdlog.so.0.0.0
b6e4f000 b6e52000 r-xp /usr/lib/libbundle.so.0.1.22
b6e62000 b6e64000 r-xp /lib/libdl-2.20-2014.11.so
b6e75000 b6e8d000 r-xp /usr/lib/libaul.so.0.1.0
b6ea1000 b6ea6000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eb7000 b6ec4000 r-xp /usr/lib/liblptcp.so
b6ed6000 b6eda000 r-xp /usr/lib/libsys-assert.so
b6eeb000 b6f0b000 r-xp /lib/ld-2.20-2014.11.so
b6f1c000 b6f21000 r-xp /usr/bin/launchpad-loader
b7f33000 b8178000 rw-p [heap]
bed1e000 bed3f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16099)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb277d64e) [/opt/usr/apps/org.example.client/bin/client] + 0x564e
 1: _ZN7MyLoginC2EP9Naviframe + 0x84 (0xb277d5d5) [/opt/usr/apps/org.example.client/bin/client] + 0x55d5
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb277d3a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb27965cf) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5cf
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb2796745) [/opt/usr/apps/org.example.client/bin/client] + 0x1e745
 5: (0xb3f5a4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6ea4203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3f5a909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb2796acf) [/opt/usr/apps/org.example.client/bin/client] + 0x1eacf
 9: main + 0x40 (0xb277d129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6f1dbb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb663f4bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f1deb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
(  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:29.352+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:29.362+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:29.382+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:29.392+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(16123) status(0)
06-13 14:02:29.402+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:29.633+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:02:29.633+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17135839
06-13 14:02:29.633+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17135839
06-13 14:02:29.633+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:02:29.633+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:02:29.633+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:02:29.633+0900 E/STARTER (  721): )
06-13 14:02:29.633+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:02:29.633+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:02:29.633+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:02:29.633+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:02:30.173+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:02:30.173+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 16123.
06-13 14:02:30.173+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1625
06-13 14:02:30.213+0900 E/EFL     (16123): ecore_x<16123> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17136365
06-13 14:02:30.213+0900 I/TASK_MGR_LITE(16123): task-mgr-lite.c: on_hw_back(132) > Back key and Key down, so call elm_exit()
06-13 14:02:30.223+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:02:30.223+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:02:30.223+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(16123)
06-13 14:02:30.223+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 16123, appid: com.samsung.task-mgr, status: bg
06-13 14:02:30.223+0900 I/CAPI_APPFW_APPLICATION(16123): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:02:30.223+0900 W/TASK_MGR_LITE(16123): task-mgr-lite.c: _pause_app(406) > 
06-13 14:02:30.223+0900 I/CAPI_APPFW_APPLICATION(16123): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:02:30.223+0900 E/TASK_MGR_LITE(16123): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:02:30.243+0900 E/APP_CORE(16123): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:02:30.243+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:02:30.253+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:02:30.253+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:02:30.253+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:02:30.253+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:02:30.253+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:02:30.293+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:02:30.323+0900 E/EFL     (16123): ecore_x<16123> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17136427
06-13 14:02:30.343+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:02:30.343+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:02:30.343+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:02:30.343+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:02:30.353+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:02:30.363+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:02:30.373+0900 I/MALI    (16123): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=16123   close drm_fd=30 
06-13 14:02:30.373+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:02:30.373+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:02:30.373+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:30.373+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:30.373+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:30.373+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:02:30.383+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:30.383+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:02:30.383+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:02:30.383+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:02:30.383+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:02:30.383+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:02:30.383+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:02:30.423+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17136549
06-13 14:02:30.423+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17136623
06-13 14:02:30.423+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:02:30.423+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:02:30.464+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:02:30.474+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:02:30.654+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16123 pgid = 16123
06-13 14:02:30.654+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16123)
06-13 14:02:30.694+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:02:30.694+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:02:30.694+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:02:30.704+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[16123] terminate event is forwarded
06-13 14:02:30.704+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:02:30.704+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 16123, ]
06-13 14:02:30.704+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:02:30.704+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:02:30.704+0900 I/Tizen::App( 1175): (512) > Not registered pid(16123)
06-13 14:02:30.704+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:02:30.704+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:02:30.704+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16123
06-13 14:02:30.704+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16123
06-13 14:02:30.704+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16123
06-13 14:02:30.724+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:02:30.724+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 16123.
06-13 14:02:31.144+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17137352
06-13 14:02:31.334+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17137540
06-13 14:02:31.354+0900 I/UXT     (16205): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:02:31.404+0900 E/TBM     (16205): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:02:31.404+0900 I/MALI    (16205): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=16205   open drm_fd=30 
06-13 14:02:31.525+0900 E/EFL     (16205): edje<16205> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:31.525+0900 E/EFL     (16205): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:31.525+0900 E/EFL     (16205): edje<16205> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:31.525+0900 E/EFL     (16205): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:31.525+0900 E/EFL     (16205): edje<16205> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:31.525+0900 E/EFL     (16205): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:31.625+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17137832
06-13 14:02:31.645+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:02:31.645+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:02:31.665+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:02:31.665+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:02:31.665+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:02:31.665+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:02:31.695+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17137909
06-13 14:02:35.218+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:02:43.716+0900 E/PKGMGR_SERVER(16247): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:02:43.766+0900 E/PKGMGR  (16245): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 14:02:43.807+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:02:43.817+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:02:43.827+0900 E/PKGMGR_SERVER(16247): pkgmgr-server.c: sighandler(417) > child NORMAL exit [16250]
06-13 14:02:45.788+0900 E/PKGMGR_SERVER(16247): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:02:45.788+0900 E/PKGMGR_SERVER(16247): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:02:48.621+0900 E/PKGMGR  (16336): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
06-13 14:02:48.701+0900 E/PKGMGR_SERVER(16338): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:02:48.751+0900 E/PKGMGR_SERVER(16338): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
06-13 14:02:48.761+0900 E/PKGMGR_SERVER(16338): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
06-13 14:02:48.761+0900 E/PKGMGR  (16336): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[163360002]
06-13 14:02:48.912+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:48.912+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:48.912+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
06-13 14:02:48.912+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
06-13 14:02:48.922+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-13 14:02:48.932+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:48.932+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:48.932+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:02:48.932+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:02:48.932+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:02:49.202+0900 E/rpm-installer(16341): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-13 14:02:49.202+0900 E/rpm-installer(16341): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-13 14:02:49.252+0900 E/PKGMGR_PARSER(16341): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-13 14:02:49.272+0900 I/PRIVACY-MANAGER-CLIENT(16341): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:02:49.272+0900 I/PRIVACY-MANAGER-CLIENT(16341): SocketClient.cpp: connect(62) > Client connected
06-13 14:02:49.272+0900 I/PRIVACY-MANAGER-SERVER(  914): SocketService.cpp: mainloop(230) > Got incoming connection
06-13 14:02:49.272+0900 I/PRIVACY-MANAGER-CLIENT(16341): SocketClient.cpp: disconnect(72) > Client disconnected
06-13 14:02:49.282+0900 E/PKGMGR_CERT(16341): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-13 14:02:49.282+0900 E/PKGMGR_CERT(16341): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-13 14:02:49.292+0900 E/PKGMGR_CERT(16341): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-13 14:02:49.322+0900 E/rpm-installer(16341): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-13 14:02:49.332+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-13 14:02:49.332+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
06-13 14:02:49.332+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:49.332+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:49.332+0900 E/ESD     (  898): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-13 14:02:49.342+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-13 14:02:49.342+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-13 14:02:49.342+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-13 14:02:50.793+0900 E/PKGMGR_SERVER(16338): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:02:51.014+0900 E/PKGMGR_SERVER(16338): pkgmgr-server.c: sighandler(417) > child NORMAL exit [16341]
06-13 14:02:52.795+0900 E/PKGMGR_SERVER(16338): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:02:52.795+0900 E/PKGMGR_SERVER(16338): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:02:52.996+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_handler_idle(1754) > Lock the display not to enter LCD OFF
06-13 14:02:52.996+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __display_lock_state(2235) > Lock LCD OFF is successfully done
06-13 14:02:53.006+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_expired(1526) > zone: /
06-13 14:02:53.026+0900 W/AUL     (  630): app_signal.c: aul_update_freezer_status(354) > send_update_freezer_status, pid: 990, type: wakeup
06-13 14:02:53.036+0900 E/RESOURCED(  667): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
06-13 14:02:53.036+0900 E/RESOURCED(  667): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
06-13 14:02:53.036+0900 E/RESOURCED(  667): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
06-13 14:02:53.036+0900 E/RESOURCED(  667): freezer-process.c: freezer_process_pid_set(146) > Cant find process info for 990
06-13 14:02:53.036+0900 E/ALARM_MANAGER(  990): alarm-lib.c: __handle_expiry_method_call(170) > [alarm-lib] Alarm expired for [ALARM.apush] : Alarm id [1971586416]
06-13 14:02:53.036+0900 E/ALARM_MANAGER(  990): alarm-lib.c: __handle_expiry_method_call(178) > [alarm-lib] Call expired callback
06-13 14:02:53.046+0900 I/AUL     (  990): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:53.056+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1971586416) zone(/)
06-13 14:02:53.056+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-13 14:02:53.056+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-6-2017, 05:04:53 (UTC).
06-13 14:02:53.056+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-13 14:02:53.056+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_handler_idle(1780) > Unlock the display from LCD OFF
06-13 14:02:53.056+0900 I/AUL     (  990): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:53.056+0900 E/ALARM_MANAGER(  990): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(15), start(13-6-2017, 14:03:08), repeat(0), interval(0), type(-1073741822)
06-13 14:02:53.066+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __display_unlock_state(2278) > Unlock LCD OFF is successfully done
06-13 14:02:53.066+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __get_zone_name(506) > zone name [/]
06-13 14:02:53.066+0900 W/ALARM_MANAGER(  630): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/990/status successfully
06-13 14:02:53.066+0900 W/ALARM_MANAGER(  630): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
06-13 14:02:53.066+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:02:53.076+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:53.086+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:53.086+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:02:53.096+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:53.106+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:53.106+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 38
06-13 14:02:53.106+0900 E/AUL_AMD (  607): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
06-13 14:02:53.106+0900 E/AUL_AMD (  607): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
06-13 14:02:53.106+0900 E/ALARM_MANAGER(  630): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1497330188, Tue Jun 13 14:03:08 2017
06-13 14:02:53.106+0900 E/ALARM_MANAGER(  630): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 2132441690, next duetime: 1497330188
06-13 14:02:53.106+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(2132441690)
06-13 14:02:53.106+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1497330293), due_time(1497330188)
06-13 14:02:53.106+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-13 14:02:53.106+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-6-2017, 05:03:08 (UTC).
06-13 14:02:53.106+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-13 14:02:53.416+0900 E/PKGMGR  (16392): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-13 14:02:53.496+0900 E/PKGMGR_SERVER(16394): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:02:53.556+0900 E/PKGMGR_SERVER(16394): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 14:02:53.566+0900 E/PKGMGR_INFO(16394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 14:02:53.566+0900 E/rpm-installer(16394): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 14:02:53.576+0900 E/PKGMGR_SERVER(16394): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 14:02:53.576+0900 E/PKGMGR  (16392): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[163920002]
06-13 14:02:53.706+0900 E/PKGMGR_INSTALLER(16397): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 14:02:53.706+0900 E/rpm-installer(16397): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 14:02:53.726+0900 E/rpm-installer(16397): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 14:02:53.726+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 14:02:53.726+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:02:53.726+0900 E/rpm-installer(16397): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 14:02:53.726+0900 E/rpm-installer(16397): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:02:53.816+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 14:02:53.826+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
06-13 14:02:53.826+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:53.826+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:53.836+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:02:53.836+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:02:53.836+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-13 14:02:53.836+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:53.836+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:54.037+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __get_zone_name(506) > zone name [/]
06-13 14:02:54.037+0900 W/ALARM_MANAGER(  630): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/990/status successfully
06-13 14:02:54.047+0900 W/ALARM_MANAGER(  630): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
06-13 14:02:54.047+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(2132441690) zone(/)
06-13 14:02:54.047+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-13 14:02:54.047+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-6-2017, 05:04:53 (UTC).
06-13 14:02:54.047+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-13 14:02:54.047+0900 E/ALARM_MANAGER(  630): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[2132441690] is removed.
06-13 14:02:54.047+0900 E/PUSHD   (  990): io.c: server_recv(270) > Fail to recv using curl
06-13 14:02:54.047+0900 E/PUSHD   (  990): proc.c: _receive_packet(2312) > ERROR : invalid return when receiving header [-1]
06-13 14:02:54.047+0900 W/PUSHD   (  990): ping.c: display_ping_status(380) > = PING_SUCCESS = avg[1200] inc[300] min[1200] max[2400] interval[1620] next_interval[1920] successes[4] max[1] mode[EXPLORE]
06-13 14:02:54.047+0900 I/AUL     (  990): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:54.057+0900 I/AUL     (  990): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:54.057+0900 E/ALARM_MANAGER(  990): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(1920), start(13-6-2017, 14:34:54), repeat(0), interval(0), type(-1073741822)
06-13 14:02:54.057+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __get_zone_name(506) > zone name [/]
06-13 14:02:54.057+0900 W/ALARM_MANAGER(  630): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/990/status successfully
06-13 14:02:54.057+0900 W/ALARM_MANAGER(  630): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
06-13 14:02:54.067+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:02:54.067+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:54.077+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:54.077+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:02:54.087+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:54.087+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
06-13 14:02:54.087+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 38
06-13 14:02:54.097+0900 E/AUL_AMD (  607): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
06-13 14:02:54.097+0900 E/AUL_AMD (  607): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
06-13 14:02:54.097+0900 E/ALARM_MANAGER(  630): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1497332094, Tue Jun 13 14:34:54 2017
06-13 14:02:54.097+0900 E/ALARM_MANAGER(  630): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 753325467, next duetime: 1497332094
06-13 14:02:54.097+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(753325467)
06-13 14:02:54.097+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1497330293), due_time(1497332094)
06-13 14:02:54.097+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-13 14:02:54.097+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-6-2017, 05:04:53 (UTC).
06-13 14:02:54.097+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-13 14:02:54.117+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 14:02:54.117+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 14:02:54.117+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 14:02:54.117+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:02:54.117+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 14:02:54.117+0900 E/rpm-installer(16397): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 14:02:54.127+0900 E/PKGMGR_PARSER(16397): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 14:02:54.127+0900 E/PKGMGR_PARSER(16397): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 14:02:54.157+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
06-13 14:02:54.167+0900 I/PRIVACY-MANAGER-CLIENT(16397): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:02:54.387+0900 E/PKGMGR_PARSER(16397): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 14:02:54.407+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 14:02:54.407+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 14:02:54.407+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 14:02:54.407+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 14:02:54.407+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 14:02:54.407+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 14:02:54.407+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 14:02:54.417+0900 E/PKGMGR_CERT(16397): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 14:02:54.417+0900 E/rpm-installer(16397): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 14:02:54.427+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:54.427+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 14:02:54.427+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:54.427+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 14:02:54.427+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
06-13 14:02:54.437+0900 E/rpm-installer(16397): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:02:54.457+0900 E/rpm-installer(16397): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 14:02:54.467+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:54.467+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 14:02:54.467+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:54.467+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 14:02:54.467+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
06-13 14:02:55.788+0900 E/PKGMGR_SERVER(16394): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:02:56.389+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:02:56.389+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:02:56.389+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:02:56.399+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:56.399+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:02:56.409+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:02:56.409+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:02:56.409+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:02:56.429+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:02:56.439+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:02:56.439+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:02:56.439+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:02:56.439+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:02:56.439+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:02:56.439+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:02:56.449+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:02:56.449+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:02:56.449+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:02:56.449+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:02:56.449+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:02:56.459+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:02:56.459+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:02:56.459+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:02:56.459+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:02:56.459+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:02:56.459+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:02:56.459+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
06-13 14:02:56.469+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:02:56.479+0900 E/PKGMGR_SERVER(16394): pkgmgr-server.c: sighandler(417) > child NORMAL exit [16397]
06-13 14:02:56.479+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:02:56.479+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:02:56.479+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:02:56.479+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:02:56.479+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:02:56.479+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:02:56.499+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:02:57.790+0900 E/PKGMGR_SERVER(16394): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:02:57.790+0900 E/PKGMGR_SERVER(16394): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:03:00.273+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 14:03:00.273+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 2:03
06-13 14:03:00.273+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 2:03"
06-13 14:03:00.273+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 2:03"
06-13 14:03:00.273+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 14:03:00.273+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147085244 Time: <font_size=31> </font_size> <font_size=31> 오후 2:03</font_size></font>"
06-13 14:03:00.803+0900 W/AUL     (16452): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:03:00.803+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:03:00.813+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:03:00.823+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:03:00.823+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:03:00.823+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 16452
06-13 14:03:00.823+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:03:00.833+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:03:00.833+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:00.843+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:00.843+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:00.843+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:00.853+0900 I/abc     (16099): abc
06-13 14:03:00.853+0900 I/CAPI_APPFW_APPLICATION(16099): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:00.863+0900 I/CAPI_APPFW_APPLICATION(16099): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:00.893+0900 E/TBM     (16099): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:00.943+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16099, appid: org.example.client
06-13 14:03:00.943+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:00.943+0900 W/AUL     (16452): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16099)
06-13 14:03:01.143+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:03:01.143+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:03:01.153+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
06-13 14:03:01.153+0900 W/LOCKSCREEN(  857): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
06-13 14:03:01.153+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
06-13 14:03:01.153+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:23b45c0
06-13 14:03:01.153+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-13 14:03:01.153+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
06-13 14:03:01.163+0900 W/APP_CORE( 1167): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
06-13 14:03:01.163+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:03:01.163+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:03:01.163+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:03:01.163+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:03:01.163+0900 E/LOCKSCREEN(  857): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-13 14:03:01.163+0900 W/INDICATOR(  665): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-13 14:03:01.163+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
06-13 14:03:01.163+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
06-13 14:03:01.163+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
06-13 14:03:01.163+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-13 14:03:01.173+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:03:01.173+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 857
06-13 14:03:01.173+0900 I/AUL_AMD (  607): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-13 14:03:01.183+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 16467
06-13 14:03:01.183+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:01.234+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 16467
06-13 14:03:01.234+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16467, appid: com.samsung.weather-m-agent
06-13 14:03:01.244+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-13 14:03:01.244+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 16467.
06-13 14:03:01.244+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16467)
06-13 14:03:01.404+0900 E/weather-agent(16467): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-13 14:03:01.404+0900 E/weather-common(16467): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-13 14:03:01.414+0900 E/weather-agent(16467): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-13 14:03:01.414+0900 E/weather-common(16467): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-13 14:03:01.414+0900 E/weather-common(16467): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-13 14:03:01.414+0900 E/weather-common(16467): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-13 14:03:01.414+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-13 14:03:01.414+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-13 14:03:01.414+0900 I/MESSAGE_PORT(16467): message-port.c: __initialize(872) > initialize
06-13 14:03:01.414+0900 W/CRASH_MANAGER(16473): worker.c: worker_job(1199) > 0416099636c69149733018
