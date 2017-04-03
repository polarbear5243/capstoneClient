S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2527
Date: 2017-04-01 23:36:57+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2527, uid 5000)

Register Information
r0   = 0xb7242a60, r1   = 0xb337c3ae
r2   = 0x80000000, r3   = 0x00000069
r4   = 0xb5a6e01f, r5   = 0x00000000
r6   = 0x00000001, r7   = 0xbefa0f30
r8   = 0xbefa1478, r9   = 0xb70852a8
r10  = 0xbefa1498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbefa0e90
lr   = 0x64656d2f, pc   = 0xb337a01c
cpsr = 0xa0030030

Memory Information
MemTotal:   987012 KB
MemFree:    210572 KB
Buffers:     36156 KB
Cached:     313572 KB
VmPeak:      98428 KB
VmSize:      98424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19440 KB
VmRSS:       19440 KB
VmData:      30108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35644 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2527 TID = 2527
2527 2528 2777 2778 

Maps Information
b13c0000 b13c8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13da000 b1bd9000 rw-p [stack:2778]
b1bd9000 b1bda000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bea000 b1bfe000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c12000 b1c13000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c23000 b1c26000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c37000 b1c38000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c48000 b1c4a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c5a000 b1c5c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c6c000 b1c7c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c8c000 b1c98000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1caa000 b24a9000 rw-p [stack:2777]
b27da000 b27e1000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27f4000 b27fa000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b280a000 b281a000 r-xp /opt/usr/apps/org.example.client/bin/client
b2963000 b2a46000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a7d000 b2aa5000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab7000 b32b6000 rw-p [stack:2528]
b32b6000 b32b8000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c8000 b32d2000 r-xp /lib/libnss_files-2.20-2014.11.so
b32e3000 b32ec000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32fd000 b330e000 r-xp /lib/libnsl-2.20-2014.11.so
b3321000 b3327000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3338000 b3339000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3361000 b3368000 r-xp /usr/lib/libminizip.so.1.0.0
b3378000 b337d000 r-xp /usr/lib/libstorage.so.0.1
b338d000 b33ec000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3402000 b3416000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3426000 b346a000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b347a000 b3482000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3492000 b34c2000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d5000 b358e000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35a2000 b35f5000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3606000 b3621000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3631000 b36f2000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3705000 b3715000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3725000 b3732000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3743000 b374a000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b375a000 b379b000 r-xp /usr/lib/libmdm.so.1.2.12
b37ab000 b37b3000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37c2000 b37d2000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37f3000 b3853000 r-xp /usr/lib/libasound.so.2.0.0
b3865000 b3868000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3878000 b387b000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b388b000 b3890000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38a0000 b38a1000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38b1000 b38bc000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38d0000 b38d7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e7000 b38ed000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38fd000 b3902000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3912000 b392d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b393d000 b3944000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3954000 b3957000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3968000 b3996000 r-xp /usr/lib/libidn.so.11.5.44
b39a6000 b39bc000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39cd000 b39d7000 r-xp /usr/lib/libcares.so.2.1.0
b39e7000 b39f1000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a01000 b3a03000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a13000 b3a14000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a24000 b3a28000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a39000 b3a61000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a72000 b3a9b000 r-xp /usr/lib/libturbojpeg.so
b3abb000 b3ac1000 r-xp /usr/lib/libgif.so.4.1.6
b3ad1000 b3b17000 r-xp /usr/lib/libcurl.so.4.3.0
b3b28000 b3b49000 r-xp /usr/lib/libexif.so.12.3.3
b3b64000 b3b79000 r-xp /usr/lib/libtts.so
b3b8a000 b3b92000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ba2000 b3c68000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c88000 b3d80000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d9f000 b3e6d000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e84000 b3e86000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e96000 b3e9c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eac000 b3ecf000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ee0000 b3ee2000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ef2000 b3ef4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f05000 b3f0a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f21000 b3f23000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f33000 b3f3a000 r-xp /usr/lib/libsensord-share.so
b3f4a000 b3f62000 r-xp /usr/lib/libsensor.so.1.1.0
b3f73000 b3f76000 r-xp /usr/lib/libXv.so.1.0.0
b3f86000 b3f8b000 r-xp /usr/lib/libutilX.so.1.1.0
b3f9b000 b3fa0000 r-xp /usr/lib/libappcore-common.so.1.1
b3fb0000 b3fb7000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fca000 b3fce000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fdf000 b40bd000 r-xp /usr/lib/libCOREGL.so.4.0
b40dd000 b40e0000 r-xp /usr/lib/libuuid.so.1.3.0
b40f0000 b4107000 r-xp /usr/lib/libblkid.so.1.1.0
b4118000 b411a000 r-xp /usr/lib/libXau.so.6.0.0
b412a000 b4171000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4183000 b4189000 r-xp /usr/lib/libjson-c.so.2.0.1
b419a000 b419e000 r-xp /usr/lib/libogg.so.0.7.1
b41ae000 b41d0000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e0000 b42c4000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42e0000 b42e3000 r-xp /usr/lib/libEGL.so.1.4
b42f4000 b42fa000 r-xp /usr/lib/libxcb-render.so.0.0.0
b430a000 b430c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b431c000 b4329000 r-xp /usr/lib/libGLESv2.so.2.0
b433a000 b439c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43b1000 b43c9000 r-xp /usr/lib/libmount.so.1.1.0
b43db000 b43ef000 r-xp /usr/lib/libxcb.so.1.1.0
b43ff000 b4406000 r-xp /lib/libcrypt-2.20-2014.11.so
b443e000 b4440000 r-xp /usr/lib/libiri.so
b4450000 b445b000 r-xp /usr/lib/libgpg-error.so.0.15.0
b446c000 b44a2000 r-xp /usr/lib/libpulse.so.0.16.2
b44b3000 b44f6000 r-xp /usr/lib/libsndfile.so.1.0.25
b450b000 b4520000 r-xp /lib/libexpat.so.1.5.2
b4532000 b45f0000 r-xp /usr/lib/libcairo.so.2.11200.14
b4604000 b460c000 r-xp /usr/lib/libdrm.so.2.4.0
b461c000 b461f000 r-xp /usr/lib/libdri2.so.0.0.0
b462f000 b467d000 r-xp /usr/lib/libssl.so.1.0.0
b4692000 b469e000 r-xp /usr/lib/libeeze.so.1.13.0
b46af000 b46b8000 r-xp /usr/lib/libethumb.so.1.13.0
b46c8000 b46cb000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46db000 b4892000 r-xp /usr/lib/libcrypto.so.1.0.0
b567d000 b5686000 r-xp /usr/lib/libXi.so.6.1.0
b5696000 b5698000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a8000 b56ac000 r-xp /usr/lib/libXtst.so.6.1.0
b56bc000 b56c2000 r-xp /usr/lib/libXrender.so.1.3.0
b56d2000 b56d8000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e8000 b56ea000 r-xp /usr/lib/libXinerama.so.1.0.0
b56fb000 b56fe000 r-xp /usr/lib/libXfixes.so.3.1.0
b570e000 b5719000 r-xp /usr/lib/libXext.so.6.4.0
b5729000 b572b000 r-xp /usr/lib/libXdamage.so.1.1.0
b573b000 b573d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b574d000 b582f000 r-xp /usr/lib/libX11.so.6.3.0
b5843000 b584a000 r-xp /usr/lib/libXcursor.so.1.0.2
b585a000 b5872000 r-xp /usr/lib/libudev.so.1.6.0
b5874000 b5877000 r-xp /lib/libattr.so.1.1.0
b5887000 b58a7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a8000 b58ad000 r-xp /usr/lib/libffi.so.6.0.2
b58be000 b58d6000 r-xp /lib/libz.so.1.2.8
b58e6000 b58e8000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f8000 b59cd000 r-xp /usr/lib/libxml2.so.2.9.2
b59e2000 b5a7d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a99000 b5a9c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aac000 b5ac5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad6000 b5ae7000 r-xp /lib/libresolv-2.20-2014.11.so
b5afb000 b5b75000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b8a000 b5b8c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b9c000 b5ba3000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb3000 b5bbd000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bce000 b5be6000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf7000 b5c1a000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c3b000 b5c4f000 r-xp /usr/lib/libector.so.1.13.0
b5c60000 b5c78000 r-xp /usr/lib/liblua-5.1.so
b5c89000 b5ce0000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf4000 b5d1c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d2d000 b5d40000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d51000 b5d8b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9c000 b5daa000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dba000 b5dc2000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd2000 b5ddf000 r-xp /usr/lib/libeio.so.1.13.0
b5def000 b5df1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e01000 b5e06000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e16000 b5e2d000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3f000 b5e5f000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6f000 b5e8f000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e91000 b5e97000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea7000 b5eb8000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec9000 b5ed0000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee0000 b5eef000 r-xp /usr/lib/libeo.so.1.13.0
b5f00000 b5f12000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f23000 b5f28000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f38000 b5f51000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f61000 b5f7e000 r-xp /usr/lib/libeet.so.1.13.0
b5f97000 b5fdf000 r-xp /usr/lib/libeina.so.1.13.0
b5ff0000 b6000000 r-xp /usr/lib/libefl.so.1.13.0
b6011000 b60f6000 r-xp /usr/lib/libicuuc.so.51.1
b6113000 b6253000 r-xp /usr/lib/libicui18n.so.51.1
b626a000 b62a2000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b4000 b62b7000 r-xp /lib/libcap.so.2.21
b62c7000 b62f0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6301000 b6308000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631a000 b6351000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6362000 b644d000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6460000 b64d9000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64eb000 b64f0000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6500000 b650a000 r-xp /usr/lib/libvconf.so.0.2.45
b651a000 b651c000 r-xp /usr/lib/libvasum.so.0.3.1
b652c000 b652e000 r-xp /usr/lib/libttrace.so.1.1
b653e000 b6541000 r-xp /usr/lib/libiniparser.so.0
b6551000 b6577000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6587000 b658c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b659d000 b65b4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c5000 b6630000 r-xp /lib/libm-2.20-2014.11.so
b6641000 b6647000 r-xp /lib/librt-2.20-2014.11.so
b6658000 b6665000 r-xp /usr/lib/libunwind.so.8.0.1
b669b000 b67bf000 r-xp /lib/libc-2.20-2014.11.so
b67d4000 b67ed000 r-xp /lib/libgcc_s-4.9.so.1
b67fd000 b68df000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f0000 b691a000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692b000 b6967000 r-xp /usr/lib/libsystemd.so.0.4.0
b6969000 b69ec000 r-xp /usr/lib/libedje.so.1.13.0
b69ff000 b6a1d000 r-xp /usr/lib/libecore.so.1.13.0
b6a3d000 b6bc4000 r-xp /usr/lib/libevas.so.1.13.0
b6bf9000 b6c0d000 r-xp /lib/libpthread-2.20-2014.11.so
b6c21000 b6e55000 r-xp /usr/lib/libelementary.so.1.13.0
b6e84000 b6e88000 r-xp /usr/lib/libsmack.so.1.0.0
b6e98000 b6e9f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eaf000 b6eb1000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec1000 b6ec4000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed4000 b6ed6000 r-xp /lib/libdl-2.20-2014.11.so
b6ee7000 b6eff000 r-xp /usr/lib/libaul.so.0.1.0
b6f13000 b6f18000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f29000 b6f36000 r-xp /usr/lib/liblptcp.so
b6f48000 b6f4c000 r-xp /usr/lib/libsys-assert.so
b6f5d000 b6f7d000 r-xp /lib/ld-2.20-2014.11.so
b6f8e000 b6f93000 r-xp /usr/bin/launchpad-loader
b7044000 b726f000 rw-p [heap]
bef81000 befa2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2527)
Call Stack Count: 15
 0: storage_get_root_directory + 0x1f (0xb337a01c) [/usr/lib/libstorage.so.0.1] + 0x201c
 1: _ZN9FileInputC2ESs + 0x28 (0xb280ecc1) [/opt/usr/apps/org.example.client/bin/client] + 0x4cc1
 2: _ZN7MyLogin6drawUIEP9Naviframe + 0x40 (0xb280db35) [/opt/usr/apps/org.example.client/bin/client] + 0x3b35
 3: _ZN7MyLoginC2EP9Naviframe + 0x48 (0xb280dac9) [/opt/usr/apps/org.example.client/bin/client] + 0x3ac9
 4: _ZN8MyWindow8onCreateEv + 0x110 (0xb280d8fd) [/opt/usr/apps/org.example.client/bin/client] + 0x38fd
 5: _ZN6Window10app_createEPv + 0x8e (0xb28136ab) [/opt/usr/apps/org.example.client/bin/client] + 0x96ab
 6: _ZN6Window17static_app_createEPv + 0x24 (0xb2813825) [/opt/usr/apps/org.example.client/bin/client] + 0x9825
 7: (0xb3fcc4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 8: appcore_efl_main + 0x152 (0xb6f16203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 9: ui_app_main + 0xc0 (0xb3fcc909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: _ZN6Window10makeWindowEiPPc + 0x11e (0xb2813baf) [/opt/usr/apps/org.example.client/bin/client] + 0x9baf
11: main + 0x40 (0xb280d685) [/opt/usr/apps/org.example.client/bin/client] + 0x3685
12: (0xb6f8fbb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
13: __libc_start_main + 0x114 (0xb66b14bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6f8feb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
( 1188): (840) > Enter.
04-01 23:36:01.618+0900 I/Tizen::App( 1188): (416) > appName = [client]
04-01 23:36:01.618+0900 I/Tizen::App( 1188): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-01 23:36:01.618+0900 I/Tizen::App( 1188): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-01 23:36:01.618+0900 I/Tizen::App( 1188): (131) > Enter
04-01 23:36:01.628+0900 I/Tizen::App( 1188): (137) > org.example.client does not have launch condition
04-01 23:36:01.628+0900 I/Tizen::App( 1188): (883) > Exit.
04-01 23:36:01.638+0900 E/util-view(  850): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-01 23:36:01.658+0900 W/HOME_APPS(  850): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-01 23:36:01.668+0900 E/PKGMGR_SERVER( 2403): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2457]
04-01 23:36:01.788+0900 E/PKGMGR_SERVER( 2403): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 23:36:01.788+0900 E/PKGMGR_SERVER( 2403): pkgmgr-server.c: main(2471) > package manager server terminated.
04-01 23:36:05.752+0900 W/AUL     ( 2513): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-01 23:36:05.752+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 0
04-01 23:36:05.762+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-01 23:36:05.772+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-01 23:36:05.772+0900 E/AUL_AMD (  608): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-01 23:36:05.772+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(2508) > caller pid : 2513
04-01 23:36:05.772+0900 E/AUL_AMD (  608): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-01 23:36:05.782+0900 E/RESOURCED(  676): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-01 23:36:05.782+0900 E/RESOURCED(  676): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 23:36:05.782+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(3052) > pad pid(-5)
04-01 23:36:05.782+0900 W/AUL_PAD ( 1487): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-01 23:36:05.782+0900 W/AUL_PAD ( 1487): launchpad.c: __send_result_to_caller(267) > Check app launching
04-01 23:36:05.792+0900 I/abc     ( 2008): abc
04-01 23:36:05.802+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: ui_app_main(789) > app_efl_main
04-01 23:36:05.802+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-01 23:36:05.832+0900 E/TBM     ( 2008): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-01 23:36:05.882+0900 W/AUL     (  608): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2008, appid: org.example.client
04-01 23:36:05.882+0900 E/AUL     (  608): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-01 23:36:05.892+0900 W/AUL     ( 2513): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2008)
04-01 23:36:05.972+0900 D/basicui ( 2008): successed to load edc file
04-01 23:36:06.022+0900 E/EFL     (  348): eo<348> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 23:36:06.022+0900 E/EFL     (  348): eo<348> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 23:36:06.042+0900 I/Tizen::System( 1188): (259) > Active app [org.exampl], current [com.samsun] 
04-01 23:36:06.042+0900 I/Tizen::Io( 1188): (729) > Entry not found
04-01 23:36:06.042+0900 I/Tizen::System( 1188): (157) > change brightness system value.
04-01 23:36:06.052+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 23:36:06.142+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(514) > [APP 2008] Event: RESET State: CREATED
04-01 23:36:06.142+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-01 23:36:06.152+0900 E/EFL     ( 2008): edje<2008> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 23:36:06.152+0900 E/EFL     ( 2008): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 23:36:06.162+0900 E/EFL     ( 2008): edje<2008> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 23:36:06.162+0900 E/EFL     ( 2008): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 23:36:06.162+0900 E/EFL     ( 2008): edje<2008> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 23:36:06.162+0900 E/EFL     ( 2008): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 23:36:06.162+0900 W/APP_CORE( 2008): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6e00002
04-01 23:36:06.162+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 35
04-01 23:36:06.182+0900 W/SWIFTKEY(  707): swiftkey_engine.cpp: IME_Generate_prediction(1361) > [0;33mwrong language[0m
04-01 23:36:06.182+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6e00002 FAILED!
04-01 23:36:06.182+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6e00002 FAILED!
04-01 23:36:06.202+0900 I/ISE_MULTI(  848): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=1[0m
04-01 23:36:06.202+0900 I/ISE_MULTI(  848): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:true] pos=0[0m
04-01 23:36:06.212+0900 I/ISE_MULTI(  848): xt9-setting.cpp: xt9_change_onoff(157) > [0;36mPrediction ON[0m
04-01 23:36:06.252+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: PAUSE State: RUNNING
04-01 23:36:06.252+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-01 23:36:06.252+0900 E/cluster-home(  850): homescreen.cpp: OnPause(260) >  app pause
04-01 23:36:06.252+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(850) status(4)
04-01 23:36:06.252+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(850)
04-01 23:36:06.252+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 850, appid: com.samsung.homescreen, status: bg
04-01 23:36:06.252+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(2008) status(3)
04-01 23:36:06.252+0900 W/AUL_AMD (  608): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 23:36:06.252+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 23:36:06.252+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(2008)
04-01 23:36:06.252+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2008, appid: org.example.client, status: fg
04-01 23:36:06.262+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
04-01 23:36:06.272+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(514) > [APP 2008] Event: RESUME State: CREATED
04-01 23:36:06.272+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-01 23:36:06.272+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-01 23:36:06.272+0900 W/AUL     ( 1217): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1217, appid: com.samsung.weather-m-widget, status: bg
04-01 23:36:06.282+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-01 23:36:06.282+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(625) > [APP 2008] Initial Launching, call the resume_cb
04-01 23:36:06.282+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 23:36:06.282+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-01 23:36:06.282+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-01 23:36:06.282+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
04-01 23:36:06.282+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-01 23:36:06.282+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
04-01 23:36:06.292+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
04-01 23:36:06.302+0900 W/CANDIDATE(  848): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 23:36:06.302+0900 W/CANDIDATE(  848): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 3[0m
04-01 23:36:06.302+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.302+0900 W/CANDIDATE(  848): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 23:36:06.302+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.312+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.312+0900 W/CANDIDATE(  848): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 3, line_count = 0[0m
04-01 23:36:06.312+0900 E/ISE_MULTI(  848): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 0  rect->height : 577[0m
04-01 23:36:06.372+0900 I/ISE_MULTI(  848): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-01 23:36:06.372+0900 I/SWIFTKEY(  707): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-01 23:36:06.372+0900 W/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-01 23:36:06.382+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
04-01 23:36:06.382+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-01 23:36:06.382+0900 I/SWIFTKEY(  707): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-01 23:36:06.532+0900 W/CANDIDATE(  848): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 23:36:06.542+0900 W/CANDIDATE(  848): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 23:36:06.633+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(2008) status(0)
04-01 23:36:06.673+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(848) status(3)
04-01 23:36:06.713+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-01 23:36:06.713+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-01 23:36:06.933+0900 E/RESOURCED(  676): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.292
04-01 23:36:06.933+0900 I/Tizen::App( 1188): (499) > LaunchedApp(org.example.client)
04-01 23:36:06.933+0900 I/Tizen::App( 1188): (733) > Finished invoking application event listener for org.example.client, 2008.
04-01 23:36:07.684+0900 I/UXT     ( 2527): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-01 23:36:07.784+0900 E/EFL     (  836): ecore_x<836> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=340997
04-01 23:36:07.784+0900 W/STARTER (  720): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
04-01 23:36:07.784+0900 E/EFL     ( 2008): ecore_x<2008> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=340997
04-01 23:36:07.784+0900 W/STARTER (  720): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
04-01 23:36:07.984+0900 E/EFL     (  836): ecore_x<836> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=341194
04-01 23:36:07.984+0900 E/EFL     ( 2008): ecore_x<2008> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=341194
04-01 23:36:07.984+0900 W/STARTER (  720): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-01 23:36:07.984+0900 E/STARTER (  720): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-01 23:36:07.984+0900 E/STARTER (  720): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-01 23:36:07.984+0900 E/STARTER (  720): )
04-01 23:36:07.984+0900 I/SYSPOPUP(  847): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-01 23:36:07.994+0900 I/SYSPOPUP(  847): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-01 23:36:07.994+0900 E/VOLUME  (  847): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-01 23:36:07.994+0900 E/VOLUME  (  847): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-01 23:36:08.194+0900 W/STARTER (  720): hw_key.c: _homekey_timer_cb(479) > [_homekey_timer_cb:479] _homekey_timer_cb, homekey count[1], lock state[0]
04-01 23:36:08.194+0900 E/STARTER (  720): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-01 23:36:08.194+0900 E/STARTER (  720): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-01 23:36:08.194+0900 E/STARTER (  720): )
04-01 23:36:08.194+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 23:36:08.194+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 850
04-01 23:36:08.204+0900 W/AUL     (  720): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
04-01 23:36:08.204+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 0
04-01 23:36:08.214+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
04-01 23:36:08.214+0900 E/AUL_AMD (  608): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-01 23:36:08.214+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(2508) > caller pid : 720
04-01 23:36:08.214+0900 E/AUL_AMD (  608): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-01 23:36:08.224+0900 W/AUL     (  608): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 850, appid: com.samsung.homescreen
04-01 23:36:08.224+0900 W/AUL_AMD (  608): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 850
04-01 23:36:08.224+0900 W/AUL_AMD (  608): amd_request.c: __send_home_launch_signal(577) > send a home launch signal
04-01 23:36:08.224+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: RESET State: PAUSED
04-01 23:36:08.224+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-01 23:36:08.234+0900 W/CAPI_APPFW_APP_CONTROL(  850): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-01 23:36:08.244+0900 W/AUL_AMD (  608): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(850), cmd(0)
04-01 23:36:08.244+0900 W/AUL     (  720): launch.c: app_request_to_launchpad(425) > request cmd(0) result(850)
04-01 23:36:08.244+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
04-01 23:36:08.244+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(566) > [APP 850] App already running, raise the window
04-01 23:36:08.244+0900 E/STARTER (  720): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
04-01 23:36:08.254+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(850) status(3)
04-01 23:36:08.254+0900 W/AUL_AMD (  608): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 23:36:08.254+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 23:36:08.254+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(850)
04-01 23:36:08.254+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 850, appid: com.samsung.homescreen, status: fg
04-01 23:36:08.294+0900 E/EFL     (  348): eo<348> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 23:36:08.294+0900 E/EFL     (  348): eo<348> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 23:36:08.304+0900 I/SWIFTKEY(  707): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-01 23:36:08.304+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: RESUME State: PAUSED
04-01 23:36:08.304+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 23:36:08.304+0900 E/cluster-home(  850): homescreen.cpp: OnResume(233) >  app resume
04-01 23:36:08.304+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(2008) status(4)
04-01 23:36:08.304+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(2008)
04-01 23:36:08.304+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2008, appid: org.example.client, status: bg
04-01 23:36:08.314+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6e00002 FAILED!
04-01 23:36:08.334+0900 E/weather-widget( 1217): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-01 23:36:08.344+0900 I/Tizen::System( 1188): (259) > Active app [com.samsun], current [org.exampl] 
04-01 23:36:08.344+0900 I/Tizen::Io( 1188): (729) > Entry not found
04-01 23:36:08.364+0900 I/Tizen::System( 1188): (157) > change brightness system value.
04-01 23:36:08.374+0900 I/ISE_MULTI(  848): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
04-01 23:36:08.384+0900 E/weather-widget( 1217): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-01 23:36:08.394+0900 E/weather-common( 1217): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-01 23:36:08.404+0900 I/TIZEN_N_SOUND_MANAGER(  922): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-01 23:36:08.404+0900 E/TIZEN_N_SOUND_MANAGER(  922): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 23:36:08.404+0900 I/TIZEN_N_SOUND_MANAGER(  922): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-01 23:36:08.404+0900 E/TIZEN_N_SOUND_MANAGER(  922): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 23:36:08.404+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 23:36:08.414+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(514) > [APP 2008] Event: PAUSE State: RUNNING
04-01 23:36:08.414+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-01 23:36:08.454+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 2008): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 33
04-01 23:36:08.454+0900 E/APP_CORE( 2008): appcore-efl.c: _capture_and_make_file(1619) > win[6e00002] widget[720] height[1280]
04-01 23:36:08.454+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
04-01 23:36:08.494+0900 I/CAPI_NETWORK_CONNECTION( 1217): connection.c: connection_create(409) > New handle created[0xb7cc31a0]
04-01 23:36:08.494+0900 I/CAPI_NETWORK_CONNECTION( 1217): connection.c: connection_get_type(463) > Connected Network = 2
04-01 23:36:08.494+0900 I/CAPI_NETWORK_CONNECTION( 1217): connection.c: connection_destroy(427) > Destroy handle: 0xb7cc31a0
04-01 23:36:08.494+0900 E/weather-common( 1217): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-01 23:36:08.494+0900 E/weather-widget( 1217): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-01 23:36:08.494+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-01 23:36:08.494+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-01 23:36:08.494+0900 W/AUL     ( 1217): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1217, appid: com.samsung.weather-m-widget, status: fg
04-01 23:36:08.685+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6e00002 FAILED!
04-01 23:36:13.439+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(514) > [APP 2008] Event: MEM_FLUSH State: PAUSED
04-01 23:36:29.905+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:36:29.905+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:36:29.905+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:36:29.905+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 23:36:29.915+0900 E/INDICATOR(  674): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 23:36:42.998+0900 E/PKGMGR_SERVER( 2568): pkgmgr-server.c: main(2414) > package manager server start
04-01 23:36:43.048+0900 E/PKGMGR  ( 2566): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 2008
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 23:36:43.088+0900 W/AUL     ( 2571): launch.c: app_request_to_launchpad(396) > request cmd(5) to(2233)
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 5
04-01 23:36:43.088+0900 E/AUL_AMD (  608): amd_request.c: __app_process_by_pid(272) > pid(2233) is dead. cmd(5) is canceled
04-01 23:36:43.088+0900 W/AUL     ( 2571): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-01 23:36:43.088+0900 E/PKGMGR_SERVER( 2571): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-01 23:36:43.088+0900 E/PKGMGR_SERVER( 2571): [0;m
04-01 23:36:43.088+0900 W/AUL     ( 2571): launch.c: app_request_to_launchpad(396) > request cmd(5) to(2008)
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 5
04-01 23:36:43.088+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(514) > [APP 2008] Event: TERMINATE State: PAUSED
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(2008), cmd(4)
04-01 23:36:43.088+0900 W/AUL     ( 2571): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
04-01 23:36:43.088+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 23:36:43.098+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-01 23:36:43.098+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 23:36:43.098+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
04-01 23:36:43.108+0900 E/PKGMGR_SERVER( 2568): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2571]
04-01 23:36:43.108+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 2008): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
04-01 23:36:43.108+0900 E/APP_CORE( 2008): appcore-efl.c: _capture_and_make_file(1619) > win[6e00002] widget[720] height[1280]
04-01 23:36:43.108+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
04-01 23:36:43.108+0900 E/APP_CORE( 2008): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-01 23:36:43.108+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-01 23:36:43.358+0900 I/AUL_PAD ( 1487): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2008 pgid = 2008
04-01 23:36:43.358+0900 I/AUL_PAD ( 1487): sigchild.h: __sigchild_action(143) > dead_pid(2008)
04-01 23:36:43.388+0900 I/AUL_PAD ( 1487): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 23:36:43.388+0900 I/AUL_PAD ( 1487): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 23:36:43.388+0900 E/AUL_PAD ( 1487): launchpad.c: main(698) > error reading sigchld info
04-01 23:36:43.388+0900 I/ESD     (  899): esd_main.c: __esd_app_dead_handler(1773) > pid: 2008
04-01 23:36:43.388+0900 I/Tizen::App( 1188): (243) > App[org.example.client] pid[2008] terminate event is forwarded
04-01 23:36:43.388+0900 I/Tizen::System( 1188): (256) > osp.accessorymanager.service provider is found.
04-01 23:36:43.388+0900 I/Tizen::System( 1188): (196) > Accessory Owner is removed [org.example.client, 2008, ]
04-01 23:36:43.388+0900 I/Tizen::System( 1188): (256) > osp.system.service provider is found.
04-01 23:36:43.388+0900 I/Tizen::App( 1188): (506) > TerminatedApp(org.example.client)
04-01 23:36:43.388+0900 I/Tizen::App( 1188): (512) > Not registered pid(2008)
04-01 23:36:43.388+0900 I/Tizen::System( 1188): (246) > Terminated app [org.example.client]
04-01 23:36:43.388+0900 I/Tizen::Io( 1188): (729) > Entry not found
04-01 23:36:43.388+0900 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2008
04-01 23:36:43.388+0900 E/RESOURCED(  676): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.298
04-01 23:36:43.398+0900 I/Tizen::System( 1188): (157) > change brightness system value.
04-01 23:36:43.398+0900 I/Tizen::App( 1188): (782) > Finished invoking application event listener for org.example.client, 2008.
04-01 23:36:45.791+0900 E/PKGMGR_SERVER( 2568): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 23:36:45.791+0900 E/PKGMGR_SERVER( 2568): pkgmgr-server.c: main(2471) > package manager server terminated.
04-01 23:36:46.892+0900 E/PKGMGR  ( 2659): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-01 23:36:46.962+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server.c: main(2414) > package manager server start
04-01 23:36:47.012+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-01 23:36:47.022+0900 E/PKGMGR_SERVER( 2661): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-01 23:36:47.022+0900 E/PKGMGR  ( 2659): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[26590002]
04-01 23:36:47.172+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-01 23:36:47.172+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-01 23:36:47.182+0900 W/AUL_AMD (  608): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-01 23:36:47.182+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-01 23:36:47.182+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [30]
04-01 23:36:47.182+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-01 23:36:47.322+0900 W/CERT_SVC_VCORE( 2664): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-01 23:36:47.382+0900 E/rpm-installer( 2664): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-01 23:36:47.382+0900 E/rpm-installer( 2664): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-01 23:36:47.442+0900 E/PKGMGR_PARSER( 2664): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-01 23:36:47.452+0900 I/PRIVACY-MANAGER-CLIENT( 2664): SocketClient.cpp: SocketClient(37) > Client created
04-01 23:36:47.452+0900 I/PRIVACY-MANAGER-CLIENT( 2664): SocketClient.cpp: connect(62) > Client connected
04-01 23:36:47.452+0900 I/PRIVACY-MANAGER-SERVER(  925): SocketService.cpp: mainloop(230) > Got incoming connection
04-01 23:36:47.462+0900 I/PRIVACY-MANAGER-CLIENT( 2664): SocketClient.cpp: disconnect(72) > Client disconnected
04-01 23:36:47.462+0900 E/PKGMGR_CERT( 2664): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-01 23:36:47.462+0900 E/PKGMGR_CERT( 2664): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-01 23:36:47.472+0900 E/PKGMGR_CERT( 2664): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-01 23:36:47.502+0900 E/rpm-installer( 2664): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-01 23:36:47.512+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-01 23:36:47.512+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-01 23:36:47.512+0900 E/ESD     (  899): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-01 23:36:47.512+0900 W/AUL_AMD (  608): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-01 23:36:47.522+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-01 23:36:47.522+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-01 23:36:48.103+0900 W/AUL_AMD (  608): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 23:36:48.103+0900 W/AUL_AMD (  608): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 23:36:48.794+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-01 23:36:49.154+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2664]
04-01 23:36:49.955+0900 E/PKGMGR  ( 2712): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-01 23:36:49.985+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-01 23:36:49.995+0900 E/PKGMGR_INFO( 2661): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-01 23:36:50.005+0900 E/rpm-installer( 2661): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-01 23:36:50.015+0900 E/PKGMGR_SERVER( 2661): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-01 23:36:50.015+0900 E/PKGMGR  ( 2712): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[27120002]
04-01 23:36:50.135+0900 E/PKGMGR_INSTALLER( 2714): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-01 23:36:50.135+0900 E/rpm-installer( 2714): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-01 23:36:50.145+0900 E/rpm-installer( 2714): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-01 23:36:50.145+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-01 23:36:50.145+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-01 23:36:50.145+0900 E/rpm-installer( 2714): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-01 23:36:50.155+0900 E/rpm-installer( 2714): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-01 23:36:50.205+0900 W/CERT_SVC_VCORE( 2714): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-01 23:36:50.265+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-01 23:36:50.265+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-01 23:36:50.275+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-01 23:36:50.275+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [30]
04-01 23:36:50.275+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-01 23:36:50.445+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-01 23:36:50.445+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-01 23:36:50.445+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-01 23:36:50.445+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-01 23:36:50.445+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-01 23:36:50.445+0900 E/rpm-installer( 2714): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-01 23:36:50.455+0900 E/PKGMGR_PARSER( 2714): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-01 23:36:50.455+0900 E/PKGMGR_PARSER( 2714): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-01 23:36:50.495+0900 I/PRIVACY-MANAGER-CLIENT( 2714): SocketClient.cpp: SocketClient(37) > Client created
04-01 23:36:50.706+0900 E/PKGMGR_PARSER( 2714): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-01 23:36:50.726+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-01 23:36:50.726+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-01 23:36:50.726+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-01 23:36:50.736+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-01 23:36:50.736+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-01 23:36:50.736+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-01 23:36:50.736+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-01 23:36:50.736+0900 E/PKGMGR_CERT( 2714): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-01 23:36:50.746+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-01 23:36:50.746+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [60]
04-01 23:36:50.746+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-01 23:36:50.756+0900 E/rpm-installer( 2714): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-01 23:36:50.776+0900 E/rpm-installer( 2714): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-01 23:36:50.786+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-01 23:36:50.786+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [100]
04-01 23:36:50.786+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-01 23:36:50.796+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-01 23:36:52.637+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-01 23:36:52.637+0900 I/Tizen::App( 1188): (78) > Installation is Completed. [Package = org.example.client]
04-01 23:36:52.637+0900 I/Tizen::App( 1188): (671) > Enter. package(org.example.client), installationResult(0)
04-01 23:36:52.647+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-01 23:36:52.647+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-01 23:36:52.647+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-01 23:36:52.647+0900 I/Tizen::App( 1188): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-01 23:36:52.657+0900 I/Tizen::App( 1188): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-01 23:36:52.687+0900 I/Tizen::App( 1188): (416) > appName = [client]
04-01 23:36:52.687+0900 I/Tizen::App( 1188): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-01 23:36:52.687+0900 E/PKGMGR_INFO( 1188): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-01 23:36:52.687+0900 I/Tizen::App( 1188): (683) > Application count(1) in this package
04-01 23:36:52.687+0900 I/Tizen::App( 1188): (840) > Enter.
04-01 23:36:52.687+0900 I/Tizen::App( 1188): (703) > Exit.
04-01 23:36:52.687+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-01 23:36:52.687+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-01 23:36:52.697+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server.c: sighandler(417) > child NORMAL exit [2714]
04-01 23:36:52.697+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-01 23:36:52.697+0900 I/Tizen::App( 1188): (416) > appName = [client]
04-01 23:36:52.697+0900 I/Tizen::App( 1188): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-01 23:36:52.697+0900 I/Tizen::App( 1188): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-01 23:36:52.697+0900 I/Tizen::App( 1188): (131) > Enter
04-01 23:36:52.708+0900 I/Tizen::App( 1188): (137) > org.example.client does not have launch condition
04-01 23:36:52.708+0900 I/Tizen::App( 1188): (883) > Exit.
04-01 23:36:52.708+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-01 23:36:52.708+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-01 23:36:52.708+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-01 23:36:52.708+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-01 23:36:52.728+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-01 23:36:52.728+0900 E/HOME_APPS(  850): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-01 23:36:52.728+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-01 23:36:52.728+0900 W/HOME_APPS(  850): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-01 23:36:52.748+0900 E/util-view(  850): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-01 23:36:52.758+0900 W/HOME_APPS(  850): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-01 23:36:52.788+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 23:36:52.788+0900 E/PKGMGR_SERVER( 2661): pkgmgr-server.c: main(2471) > package manager server terminated.
04-01 23:36:56.842+0900 W/AUL     ( 2770): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-01 23:36:56.842+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 0
04-01 23:36:56.852+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-01 23:36:56.862+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-01 23:36:56.862+0900 E/AUL_AMD (  608): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-01 23:36:56.862+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(2508) > caller pid : 2770
04-01 23:36:56.862+0900 E/AUL_AMD (  608): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-01 23:36:56.872+0900 E/RESOURCED(  676): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-01 23:36:56.872+0900 E/RESOURCED(  676): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 23:36:56.872+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(3052) > pad pid(-5)
04-01 23:36:56.872+0900 W/AUL_PAD ( 1487): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-01 23:36:56.872+0900 W/AUL_PAD ( 1487): launchpad.c: __send_result_to_caller(267) > Check app launching
04-01 23:36:56.892+0900 I/abc     ( 2527): abc
04-01 23:36:56.892+0900 I/CAPI_APPFW_APPLICATION( 2527): app_main.c: ui_app_main(789) > app_efl_main
04-01 23:36:56.892+0900 I/CAPI_APPFW_APPLICATION( 2527): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-01 23:36:56.922+0900 E/TBM     ( 2527): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-01 23:36:56.972+0900 W/AUL     (  608): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2527, appid: org.example.client
04-01 23:36:56.972+0900 E/AUL     (  608): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-01 23:36:56.992+0900 W/AUL     ( 2770): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2527)
04-01 23:36:57.322+0900 W/CRASH_MANAGER( 2786): worker.c: worker_job(1199) > 1102527636c69149105741
