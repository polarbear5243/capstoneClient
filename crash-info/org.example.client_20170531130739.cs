S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 25323
Date: 2017-05-31 13:07:39+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25323, uid 5000)

Register Information
r0   = 0xbed89090, r1   = 0x000021ca
r2   = 0x000021ca, r3   = 0xbed89090
r4   = 0xb2811ced, r5   = 0xb80a4a70
r6   = 0xb80d0f78, r7   = 0xbed88fd8
r8   = 0x80060102, r9   = 0xb5f15708
r10  = 0xb7fe6ad8, fp   = 0x00000000
ip   = 0xb28309b8, sp   = 0xbed88fb0
lr   = 0xb27fb0a7, pc   = 0xb27fb0e2
cpsr = 0x80070030

Memory Information
MemTotal:   987012 KB
MemFree:     74672 KB
Buffers:     74584 KB
Cached:     270748 KB
VmPeak:     134464 KB
VmSize:     133268 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27932 KB
VmRSS:       27244 KB
VmData:      45400 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 25323 TID = 25323
25323 25324 25354 25355 25393 

Maps Information
af22e000 afa2d000 rw-p [stack:25393]
b13ac000 b13b4000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13c6000 b1bc5000 rw-p [stack:25355]
b1bc5000 b1bc6000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd6000 b1bea000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bfe000 b1bff000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c0f000 b1c12000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c23000 b1c24000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c34000 b1c36000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c46000 b1c48000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c58000 b1c68000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c78000 b1c84000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c96000 b2495000 rw-p [stack:25354]
b27c6000 b27cd000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e0000 b27e6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f6000 b2820000 r-xp /opt/usr/apps/org.example.client/bin/client
b2979000 b2a5c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a93000 b2abb000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2acd000 b32cc000 rw-p [stack:25324]
b32cc000 b32ce000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32de000 b32e8000 r-xp /lib/libnss_files-2.20-2014.11.so
b32f9000 b3302000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3313000 b3324000 r-xp /lib/libnsl-2.20-2014.11.so
b3337000 b333d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b334e000 b334f000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3377000 b337e000 r-xp /usr/lib/libminizip.so.1.0.0
b338e000 b3393000 r-xp /usr/lib/libstorage.so.0.1
b33a3000 b3402000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3418000 b342c000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b343c000 b3480000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3490000 b3498000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34a8000 b34d8000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34eb000 b35a4000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35b8000 b360b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b361c000 b3637000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3647000 b3708000 r-xp /usr/lib/libprotobuf.so.9.0.1
b371b000 b372b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b373b000 b3748000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3759000 b3760000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3770000 b37b1000 r-xp /usr/lib/libmdm.so.1.2.12
b37c1000 b37c9000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37d8000 b37e8000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3809000 b3869000 r-xp /usr/lib/libasound.so.2.0.0
b387b000 b387e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b388e000 b3891000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a1000 b38a6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b6000 b38b7000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38c7000 b38d2000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e6000 b38ed000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38fd000 b3903000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3913000 b3918000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3928000 b3943000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3953000 b395a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b396a000 b396d000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b397e000 b39ac000 r-xp /usr/lib/libidn.so.11.5.44
b39bc000 b39d2000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e3000 b39ed000 r-xp /usr/lib/libcares.so.2.1.0
b39fd000 b3a07000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a17000 b3a19000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a29000 b3a2a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a3a000 b3a3e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a4f000 b3a77000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a88000 b3ab1000 r-xp /usr/lib/libturbojpeg.so
b3ad1000 b3ad7000 r-xp /usr/lib/libgif.so.4.1.6
b3ae7000 b3b2d000 r-xp /usr/lib/libcurl.so.4.3.0
b3b3e000 b3b5f000 r-xp /usr/lib/libexif.so.12.3.3
b3b7a000 b3b8f000 r-xp /usr/lib/libtts.so
b3ba0000 b3ba8000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bb8000 b3c7e000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c9e000 b3d96000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db5000 b3e83000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e9a000 b3e9c000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eac000 b3eb2000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec2000 b3ee5000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef6000 b3ef8000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f08000 b3f0a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f1b000 b3f20000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f37000 b3f39000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f49000 b3f50000 r-xp /usr/lib/libsensord-share.so
b3f60000 b3f78000 r-xp /usr/lib/libsensor.so.1.1.0
b3f89000 b3f8c000 r-xp /usr/lib/libXv.so.1.0.0
b3f9c000 b3fa1000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb1000 b3fb6000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc6000 b3fcd000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe0000 b3fe4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff5000 b40d3000 r-xp /usr/lib/libCOREGL.so.4.0
b40f3000 b40f6000 r-xp /usr/lib/libuuid.so.1.3.0
b4106000 b411d000 r-xp /usr/lib/libblkid.so.1.1.0
b412e000 b4130000 r-xp /usr/lib/libXau.so.6.0.0
b4140000 b4187000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4199000 b419f000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b0000 b41b4000 r-xp /usr/lib/libogg.so.0.7.1
b41c4000 b41e6000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f6000 b42da000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f6000 b42f9000 r-xp /usr/lib/libEGL.so.1.4
b430a000 b4310000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4320000 b4322000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4332000 b433f000 r-xp /usr/lib/libGLESv2.so.2.0
b4350000 b43b2000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43c7000 b43df000 r-xp /usr/lib/libmount.so.1.1.0
b43f1000 b4405000 r-xp /usr/lib/libxcb.so.1.1.0
b4415000 b441c000 r-xp /lib/libcrypt-2.20-2014.11.so
b4454000 b4456000 r-xp /usr/lib/libiri.so
b4466000 b4471000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4482000 b44b8000 r-xp /usr/lib/libpulse.so.0.16.2
b44c9000 b450c000 r-xp /usr/lib/libsndfile.so.1.0.25
b4521000 b4536000 r-xp /lib/libexpat.so.1.5.2
b4548000 b4606000 r-xp /usr/lib/libcairo.so.2.11200.14
b461a000 b4622000 r-xp /usr/lib/libdrm.so.2.4.0
b4632000 b4635000 r-xp /usr/lib/libdri2.so.0.0.0
b4645000 b4693000 r-xp /usr/lib/libssl.so.1.0.0
b46a8000 b46b4000 r-xp /usr/lib/libeeze.so.1.13.0
b46c5000 b46ce000 r-xp /usr/lib/libethumb.so.1.13.0
b46de000 b46e1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f1000 b48a8000 r-xp /usr/lib/libcrypto.so.1.0.0
b5693000 b569c000 r-xp /usr/lib/libXi.so.6.1.0
b56ac000 b56ae000 r-xp /usr/lib/libXgesture.so.7.0.0
b56be000 b56c2000 r-xp /usr/lib/libXtst.so.6.1.0
b56d2000 b56d8000 r-xp /usr/lib/libXrender.so.1.3.0
b56e8000 b56ee000 r-xp /usr/lib/libXrandr.so.2.2.0
b56fe000 b5700000 r-xp /usr/lib/libXinerama.so.1.0.0
b5711000 b5714000 r-xp /usr/lib/libXfixes.so.3.1.0
b5724000 b572f000 r-xp /usr/lib/libXext.so.6.4.0
b573f000 b5741000 r-xp /usr/lib/libXdamage.so.1.1.0
b5751000 b5753000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5763000 b5845000 r-xp /usr/lib/libX11.so.6.3.0
b5859000 b5860000 r-xp /usr/lib/libXcursor.so.1.0.2
b5870000 b5888000 r-xp /usr/lib/libudev.so.1.6.0
b588a000 b588d000 r-xp /lib/libattr.so.1.1.0
b589d000 b58bd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58be000 b58c3000 r-xp /usr/lib/libffi.so.6.0.2
b58d4000 b58ec000 r-xp /lib/libz.so.1.2.8
b58fc000 b58fe000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b590e000 b59e3000 r-xp /usr/lib/libxml2.so.2.9.2
b59f8000 b5a93000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aaf000 b5ab2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac2000 b5adb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aec000 b5afd000 r-xp /lib/libresolv-2.20-2014.11.so
b5b11000 b5b8b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba0000 b5ba2000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb2000 b5bb9000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc9000 b5bd3000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be4000 b5bfc000 r-xp /usr/lib/libpng12.so.0.50.0
b5c0d000 b5c30000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c51000 b5c65000 r-xp /usr/lib/libector.so.1.13.0
b5c76000 b5c8e000 r-xp /usr/lib/liblua-5.1.so
b5c9f000 b5cf6000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d0a000 b5d32000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d43000 b5d56000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d67000 b5da1000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db2000 b5dc0000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd0000 b5dd8000 r-xp /usr/lib/libtbm.so.1.0.0
b5de8000 b5df5000 r-xp /usr/lib/libeio.so.1.13.0
b5e05000 b5e07000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e17000 b5e1c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e2c000 b5e43000 r-xp /usr/lib/libefreet.so.1.13.0
b5e55000 b5e75000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e85000 b5ea5000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea7000 b5ead000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ebd000 b5ece000 r-xp /usr/lib/libemotion.so.1.13.0
b5edf000 b5ee6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef6000 b5f05000 r-xp /usr/lib/libeo.so.1.13.0
b5f16000 b5f28000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f39000 b5f3e000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f4e000 b5f67000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f77000 b5f94000 r-xp /usr/lib/libeet.so.1.13.0
b5fad000 b5ff5000 r-xp /usr/lib/libeina.so.1.13.0
b6006000 b6016000 r-xp /usr/lib/libefl.so.1.13.0
b6027000 b610c000 r-xp /usr/lib/libicuuc.so.51.1
b6129000 b6269000 r-xp /usr/lib/libicui18n.so.51.1
b6280000 b62b8000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ca000 b62cd000 r-xp /lib/libcap.so.2.21
b62dd000 b6306000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6317000 b631e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6330000 b6367000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6378000 b6463000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6476000 b64ef000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6501000 b6506000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6516000 b6520000 r-xp /usr/lib/libvconf.so.0.2.45
b6530000 b6532000 r-xp /usr/lib/libvasum.so.0.3.1
b6542000 b6544000 r-xp /usr/lib/libttrace.so.1.1
b6554000 b6557000 r-xp /usr/lib/libiniparser.so.0
b6567000 b658d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b659d000 b65a2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b3000 b65ca000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65db000 b6646000 r-xp /lib/libm-2.20-2014.11.so
b6657000 b665d000 r-xp /lib/librt-2.20-2014.11.so
b666e000 b667b000 r-xp /usr/lib/libunwind.so.8.0.1
b66b1000 b67d5000 r-xp /lib/libc-2.20-2014.11.so
b67ea000 b6803000 r-xp /lib/libgcc_s-4.9.so.1
b6813000 b68f5000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6906000 b6930000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6941000 b697d000 r-xp /usr/lib/libsystemd.so.0.4.0
b697f000 b6a02000 r-xp /usr/lib/libedje.so.1.13.0
b6a15000 b6a33000 r-xp /usr/lib/libecore.so.1.13.0
b6a53000 b6bda000 r-xp /usr/lib/libevas.so.1.13.0
b6c0f000 b6c23000 r-xp /lib/libpthread-2.20-2014.11.so
b6c37000 b6e6b000 r-xp /usr/lib/libelementary.so.1.13.0
b6e9a000 b6e9e000 r-xp /usr/lib/libsmack.so.1.0.0
b6eae000 b6eb5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec5000 b6ec7000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed7000 b6eda000 r-xp /usr/lib/libbundle.so.0.1.22
b6eea000 b6eec000 r-xp /lib/libdl-2.20-2014.11.so
b6efd000 b6f15000 r-xp /usr/lib/libaul.so.0.1.0
b6f29000 b6f2e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3f000 b6f4c000 r-xp /usr/lib/liblptcp.so
b6f5e000 b6f62000 r-xp /usr/lib/libsys-assert.so
b6f73000 b6f93000 r-xp /lib/ld-2.20-2014.11.so
b6fa4000 b6fa9000 r-xp /usr/bin/launchpad-loader
b7daa000 b8111000 rw-p [heap]
bed69000 bed8a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25323)
Call Stack Count: 26
 0:  + 0x0 (0xb27fb0e2) [/opt/usr/apps/org.example.client/bin/client] + 0x50e2
 1: _ZN8UILayoutC2ERKS_ + 0x1a (0xb27fb0a7) [/opt/usr/apps/org.example.client/bin/client] + 0x50a7
 2: _ZN13RecommendView6drawUIEP9Naviframe + 0x1be (0xb28081e3) [/opt/usr/apps/org.example.client/bin/client] + 0x121e3
 3: _ZN13RecommendViewC2EP9Naviframe + 0x3a (0xb2807fab) [/opt/usr/apps/org.example.client/bin/client] + 0x11fab
 4: _ZN12RecommendBtn5clickEv + 0x2a (0xb2807f55) [/opt/usr/apps/org.example.client/bin/client] + 0x11f55
 5: _ZN6Button14callback_clickEPvP10_Eo_OpaqueS0_ + 0x24 (0xb2811d11) [/opt/usr/apps/org.example.client/bin/client] + 0x1bd11
 6: (0xb6ab97ed) [/usr/lib/libevas.so.1] + 0x667ed
 7: (0xb5f01219) [/usr/lib/libeo.so.1] + 0xb219
 8: eo_event_callback_call + 0x68 (0xb5efffb9) [/usr/lib/libeo.so.1] + 0x9fb9
 9: evas_object_smart_callback_call + 0x38 (0xb6abaedd) [/usr/lib/libevas.so.1] + 0x67edd
10: (0xb69d6167) [/usr/lib/libedje.so.1] + 0x57167
11: (0xb69dad87) [/usr/lib/libedje.so.1] + 0x5bd87
12: (0xb69d6b21) [/usr/lib/libedje.so.1] + 0x57b21
13: (0xb69d6ef1) [/usr/lib/libedje.so.1] + 0x57ef1
14: (0xb69d7045) [/usr/lib/libedje.so.1] + 0x58045
15: (0xb6a24d11) [/usr/lib/libecore.so.1] + 0xfd11
16: (0xb6a20c4b) [/usr/lib/libecore.so.1] + 0xbc4b
17: (0xb6a26a5d) [/usr/lib/libecore.so.1] + 0x11a5d
18: ecore_main_loop_begin + 0x3e (0xb6a26c83) [/usr/lib/libecore.so.1] + 0x11c83
19: appcore_efl_main + 0x20c (0xb6f2c2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
20: ui_app_main + 0xc0 (0xb3fe2909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
21: _ZN6Window10makeWindowEiPPc + 0x11e (0xb2810957) [/opt/usr/apps/org.example.client/bin/client] + 0x1a957
22: main + 0x40 (0xb27facd1) [/opt/usr/apps/org.example.client/bin/client] + 0x4cd1
23: (0xb6fa5bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
24: __libc_start_main + 0x114 (0xb66c74bc) [/lib/libc.so.6] + 0x164bc
25: (0xb6fa5eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
05-31 13:07:18.353+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [30]
05-31 13:07:18.353+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.573+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
05-31 13:07:18.623+0900 E/PKGMGR_PARSER(25255): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
05-31 13:07:18.633+0900 E/PKGMGR_PARSER(25255): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
05-31 13:07:18.663+0900 I/PRIVACY-MANAGER-CLIENT(25255): SocketClient.cpp: SocketClient(37) > Client created
05-31 13:07:18.873+0900 E/PKGMGR_PARSER(25255): pkgmgr_parser.c: __check_theme(142) > theme for installation.
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
05-31 13:07:18.903+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [60]
05-31 13:07:18.903+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.923+0900 E/rpm-installer(25255): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
05-31 13:07:18.943+0900 E/rpm-installer(25255): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [100]
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.565+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-31 13:07:20.775+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
05-31 13:07:20.775+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
05-31 13:07:20.775+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
05-31 13:07:20.775+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
05-31 13:07:20.775+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
05-31 13:07:20.805+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
05-31 13:07:20.825+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
05-31 13:07:20.825+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
05-31 13:07:20.825+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
05-31 13:07:20.825+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
05-31 13:07:20.825+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 13:07:20.845+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (840) > Enter.
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (703) > Exit.
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
05-31 13:07:20.855+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (131) > Enter
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (883) > Exit.
05-31 13:07:20.875+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
05-31 13:07:20.905+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: sighandler(417) > child NORMAL exit [25255]
05-31 13:07:22.567+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-31 13:07:22.567+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: main(2471) > package manager server terminated.
05-31 13:07:24.969+0900 W/AUL     (25309): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
05-31 13:07:24.969+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 13:07:24.969+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
05-31 13:07:24.979+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
05-31 13:07:24.979+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
05-31 13:07:24.979+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 25309
05-31 13:07:24.979+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
05-31 13:07:24.989+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
05-31 13:07:24.989+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 13:07:24.989+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
05-31 13:07:24.989+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
05-31 13:07:24.989+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
05-31 13:07:25.009+0900 I/abc     (25060): abc
05-31 13:07:25.009+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: ui_app_main(789) > app_efl_main
05-31 13:07:25.009+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
05-31 13:07:25.039+0900 E/TBM     (25060): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
05-31 13:07:25.089+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 25060, appid: org.example.client
05-31 13:07:25.099+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
05-31 13:07:25.109+0900 W/AUL     (25309): launch.c: app_request_to_launchpad(425) > request cmd(0) result(25060)
05-31 13:07:25.109+0900 E/RESOURCED(  678): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.client
05-31 13:07:25.320+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(514) > [APP 25060] Event: RESET State: CREATED
05-31 13:07:25.320+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
05-31 13:07:25.330+0900 E/EFL     (25060): edje<25060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:25.330+0900 E/EFL     (25060): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:25.340+0900 E/EFL     (25060): edje<25060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:25.340+0900 E/EFL     (25060): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:25.340+0900 E/EFL     (25060): edje<25060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:25.340+0900 E/EFL     (25060): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:25.350+0900 W/APP_CORE(25060): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-31 13:07:25.350+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
05-31 13:07:25.350+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:25.350+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:25.370+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
05-31 13:07:25.370+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 13:07:25.380+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 13:07:25.390+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 13:07:25.460+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
05-31 13:07:25.460+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 13:07:25.460+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(514) > [APP 25060] Event: RESUME State: CREATED
05-31 13:07:25.460+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
05-31 13:07:25.470+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
05-31 13:07:25.470+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25060) status(3)
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 13:07:25.470+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(25060)
05-31 13:07:25.470+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 25060, appid: org.example.client, status: fg
05-31 13:07:25.480+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 13:07:25.480+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(625) > [APP 25060] Initial Launching, call the resume_cb
05-31 13:07:25.480+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 13:07:25.480+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
05-31 13:07:25.480+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
05-31 13:07:25.480+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
05-31 13:07:25.820+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25060) status(0)
05-31 13:07:26.140+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 13:07:26.140+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 25060.
05-31 13:07:26.140+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1487
05-31 13:07:26.821+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766566254
05-31 13:07:26.931+0900 I/UXT     (25323): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 13:07:26.951+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766566386
05-31 13:07:27.221+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766566650
05-31 13:07:27.221+0900 I/MY_LOG  (25060): Button pressed
05-31 13:07:27.312+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766566738
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: vconf_get_bool(2729) > vconf_get_bool(25060) : db/ise/keysound error
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 13:07:27.362+0900 I/MY_LOG  (25060): Button unpressed
05-31 13:07:28.182+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766567616
05-31 13:07:28.192+0900 I/MY_LOG  (25060): Button pressed
05-31 13:07:28.232+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766567660
05-31 13:07:28.232+0900 I/MY_LOG  (25060): Button unpressed
05-31 13:07:28.603+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:28.613+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
05-31 13:07:28.613+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 13:07:28.613+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 13:07:28.613+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
05-31 13:07:28.613+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
05-31 13:07:28.623+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 25060 pgid = 25060
05-31 13:07:28.623+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(25060)
05-31 13:07:28.673+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-31 13:07:28.673+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-31 13:07:28.673+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-31 13:07:28.673+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 25060
05-31 13:07:28.673+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[25060] terminate event is forwarded
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 25060, ]
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 13:07:28.673+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
05-31 13:07:28.673+0900 I/Tizen::App( 1233): (512) > Not registered pid(25060)
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
05-31 13:07:28.673+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 13:07:28.673+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25060
05-31 13:07:28.673+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 25060
05-31 13:07:28.683+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1491
05-31 13:07:28.683+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
05-31 13:07:28.693+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 13:07:28.693+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 25060.
05-31 13:07:28.703+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
05-31 13:07:28.703+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 13:07:28.703+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
05-31 13:07:28.703+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:28.713+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
05-31 13:07:28.733+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
05-31 13:07:28.733+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 13:07:28.743+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 13:07:28.753+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
05-31 13:07:28.773+0900 W/CRASH_MANAGER(25329): worker.c: worker_job(1199) > 1125060636c691496203648
05-31 13:07:28.773+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
05-31 13:07:28.773+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 13:07:28.783+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
05-31 13:07:28.783+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 13:07:28.783+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 13:07:28.783+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
05-31 13:07:28.803+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb81af090]
05-31 13:07:28.813+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
05-31 13:07:28.813+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb81af090
05-31 13:07:28.813+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
05-31 13:07:28.813+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
05-31 13:07:28.813+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
05-31 13:07:28.813+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
05-31 13:07:28.813+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
05-31 13:07:32.206+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766571644
05-31 13:07:32.346+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766571787
05-31 13:07:32.356+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
05-31 13:07:32.356+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 1
05-31 13:07:32.356+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 867
05-31 13:07:32.366+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
05-31 13:07:32.366+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 13:07:32.366+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
05-31 13:07:32.366+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
05-31 13:07:32.366+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
05-31 13:07:32.386+0900 I/abc     (25323): abc
05-31 13:07:32.386+0900 I/CAPI_APPFW_APPLICATION(25323): app_main.c: ui_app_main(789) > app_efl_main
05-31 13:07:32.386+0900 I/CAPI_APPFW_APPLICATION(25323): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
05-31 13:07:32.416+0900 E/TBM     (25323): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
05-31 13:07:32.467+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 25323, appid: org.example.client
05-31 13:07:32.467+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
05-31 13:07:32.467+0900 E/RESOURCED(  678): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.client
05-31 13:07:32.477+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(425) > request cmd(1) result(25323)
05-31 13:07:32.727+0900 I/APP_CORE(25323): appcore-efl.c: __do_app(514) > [APP 25323] Event: RESET State: CREATED
05-31 13:07:32.727+0900 I/CAPI_APPFW_APPLICATION(25323): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
05-31 13:07:32.747+0900 E/EFL     (25323): edje<25323> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:32.747+0900 E/EFL     (25323): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:32.757+0900 E/EFL     (25323): edje<25323> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:32.757+0900 E/EFL     (25323): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:32.757+0900 E/EFL     (25323): edje<25323> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:32.757+0900 E/EFL     (25323): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:32.767+0900 W/APP_CORE(25323): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
05-31 13:07:32.767+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
05-31 13:07:32.777+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:32.777+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:32.797+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
05-31 13:07:32.797+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 13:07:32.807+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 13:07:32.817+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 13:07:32.907+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
05-31 13:07:32.907+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 13:07:32.907+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
05-31 13:07:32.907+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
05-31 13:07:32.907+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
05-31 13:07:32.907+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
05-31 13:07:32.917+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25323) status(3)
05-31 13:07:32.917+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(25323)
05-31 13:07:32.917+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 25323, appid: org.example.client, status: fg
05-31 13:07:32.917+0900 I/APP_CORE(25323): appcore-efl.c: __do_app(514) > [APP 25323] Event: RESUME State: CREATED
05-31 13:07:32.927+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
05-31 13:07:32.927+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
05-31 13:07:32.927+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
05-31 13:07:32.937+0900 I/APP_CORE(25323): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 13:07:32.937+0900 I/APP_CORE(25323): appcore-efl.c: __do_app(625) > [APP 25323] Initial Launching, call the resume_cb
05-31 13:07:32.937+0900 I/CAPI_APPFW_APPLICATION(25323): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 13:07:33.277+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25323) status(0)
05-31 13:07:33.508+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 13:07:33.508+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 25323.
05-31 13:07:33.868+0900 E/EFL     (25323): ecore_x<25323> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766573300
05-31 13:07:33.998+0900 E/EFL     (25323): ecore_x<25323> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766573433
05-31 13:07:34.328+0900 I/UXT     (25362): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 13:07:35.009+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 13:07:35.019+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 13:07:35.019+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 13:07:37.912+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
05-31 13:07:38.542+0900 E/EFL     (25323): ecore_x<25323> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766577974
05-31 13:07:38.542+0900 I/MY_LOG  (25323): Button pressed
05-31 13:07:38.693+0900 E/EFL     (25323): ecore_x<25323> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766578118
05-31 13:07:38.693+0900 E/VCONF   (25323): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 13:07:38.693+0900 E/VCONF   (25323): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 13:07:38.693+0900 E/VCONF   (25323): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 13:07:38.693+0900 E/VCONF   (25323): vconf.c: vconf_get_bool(2729) > vconf_get_bool(25323) : db/ise/keysound error
05-31 13:07:38.693+0900 E/VCONF   (25323): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 13:07:38.693+0900 E/VCONF   (25323): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 13:07:38.753+0900 I/MY_LOG  (25323): Button unpressed
05-31 13:07:39.453+0900 E/EFL     (25323): ecore_x<25323> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766578879
05-31 13:07:39.453+0900 I/MY_LOG  (25323): Button pressed
05-31 13:07:39.603+0900 E/EFL     (25323): ecore_x<25323> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766579034
05-31 13:07:39.603+0900 I/MY_LOG  (25323): Button unpressed
05-31 13:07:39.944+0900 W/CRASH_MANAGER(25329): worker.c: worker_job(1199) > 1125323636c69149620365
