S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 16621
Date: 2017-06-13 14:04:27+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb278864e

Register Information
r0   = 0xb7b529d0, r1   = 0xb7b4e908
r2   = 0xb7b4e908, r3   = 0xb7b529d0
r4   = 0xb3f77a3c, r5   = 0xbee72484
r6   = 0x00000001, r7   = 0xbee72348
r8   = 0xbee72478, r9   = 0xb7a3d698
r10  = 0xbee72498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbee722ec
lr   = 0xb27885d5, pc   = 0xb278864e
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     71960 KB
Buffers:     63052 KB
Cached:     226520 KB
VmPeak:      90468 KB
VmSize:      90464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19544 KB
VmRSS:       19544 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 16621 TID = 16621
16621 16625 17021 

Maps Information
b1b39000 b1b41000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b52000 b1b53000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b63000 b1b77000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b8b000 b1b8c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b9c000 b1b9f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bb0000 b1bb1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bc1000 b1bc3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bd3000 b1bd5000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1be5000 b1bf5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c05000 b1c11000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c23000 b2422000 rw-p [stack:17021]
b2753000 b275a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b276d000 b2773000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2783000 b27b3000 r-xp /opt/usr/apps/org.example.client/bin/client
b28fc000 b29df000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a16000 b2a3e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a50000 b324f000 rw-p [stack:16625]
b324f000 b3251000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3261000 b326b000 r-xp /lib/libnss_files-2.20-2014.11.so
b327c000 b3285000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3296000 b32a7000 r-xp /lib/libnsl-2.20-2014.11.so
b32ba000 b32c0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d1000 b32d2000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32fa000 b3301000 r-xp /usr/lib/libminizip.so.1.0.0
b3311000 b3316000 r-xp /usr/lib/libstorage.so.0.1
b3326000 b3385000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b339b000 b33af000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33bf000 b3403000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3413000 b341b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b342b000 b345b000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b346e000 b3527000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b353b000 b358e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b359f000 b35ba000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ca000 b368b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b369e000 b36ae000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36be000 b36cb000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36dc000 b36e3000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36f3000 b3734000 r-xp /usr/lib/libmdm.so.1.2.12
b3744000 b374c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b375b000 b376b000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b378c000 b37ec000 r-xp /usr/lib/libasound.so.2.0.0
b37fe000 b3801000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3811000 b3814000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3824000 b3829000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3839000 b383a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b384a000 b3855000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3869000 b3870000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3880000 b3886000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3896000 b389b000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38ab000 b38c6000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38d6000 b38dd000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ed000 b38f0000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3901000 b392f000 r-xp /usr/lib/libidn.so.11.5.44
b393f000 b3955000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3966000 b3970000 r-xp /usr/lib/libcares.so.2.1.0
b3980000 b398a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b399a000 b399c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ac000 b39ad000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39bd000 b39c1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39d2000 b39fa000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a0b000 b3a34000 r-xp /usr/lib/libturbojpeg.so
b3a54000 b3a5a000 r-xp /usr/lib/libgif.so.4.1.6
b3a6a000 b3ab0000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac1000 b3ae2000 r-xp /usr/lib/libexif.so.12.3.3
b3afd000 b3b12000 r-xp /usr/lib/libtts.so
b3b23000 b3b2b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b3b000 b3c01000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c21000 b3d19000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d38000 b3e06000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e1d000 b3e1f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e2f000 b3e35000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e45000 b3e68000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e79000 b3e7b000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e8b000 b3e8d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e9e000 b3ea3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eba000 b3ebc000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ecc000 b3ed3000 r-xp /usr/lib/libsensord-share.so
b3ee3000 b3efb000 r-xp /usr/lib/libsensor.so.1.1.0
b3f0c000 b3f0f000 r-xp /usr/lib/libXv.so.1.0.0
b3f1f000 b3f24000 r-xp /usr/lib/libutilX.so.1.1.0
b3f34000 b3f39000 r-xp /usr/lib/libappcore-common.so.1.1
b3f49000 b3f50000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f63000 b3f67000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f78000 b4056000 r-xp /usr/lib/libCOREGL.so.4.0
b4076000 b4079000 r-xp /usr/lib/libuuid.so.1.3.0
b4089000 b40a0000 r-xp /usr/lib/libblkid.so.1.1.0
b40b1000 b40b3000 r-xp /usr/lib/libXau.so.6.0.0
b40c3000 b410a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b411c000 b4122000 r-xp /usr/lib/libjson-c.so.2.0.1
b4133000 b4137000 r-xp /usr/lib/libogg.so.0.7.1
b4147000 b4169000 r-xp /usr/lib/libvorbis.so.0.4.3
b4179000 b425d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4279000 b427c000 r-xp /usr/lib/libEGL.so.1.4
b428d000 b4293000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42a3000 b42a5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42b5000 b42c2000 r-xp /usr/lib/libGLESv2.so.2.0
b42d3000 b4335000 r-xp /usr/lib/libpixman-1.so.0.28.2
b434a000 b4362000 r-xp /usr/lib/libmount.so.1.1.0
b4374000 b4388000 r-xp /usr/lib/libxcb.so.1.1.0
b4398000 b439f000 r-xp /lib/libcrypt-2.20-2014.11.so
b43d7000 b43d9000 r-xp /usr/lib/libiri.so
b43e9000 b43f4000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4405000 b443b000 r-xp /usr/lib/libpulse.so.0.16.2
b444c000 b448f000 r-xp /usr/lib/libsndfile.so.1.0.25
b44a4000 b44b9000 r-xp /lib/libexpat.so.1.5.2
b44cb000 b4589000 r-xp /usr/lib/libcairo.so.2.11200.14
b459d000 b45a5000 r-xp /usr/lib/libdrm.so.2.4.0
b45b5000 b45b8000 r-xp /usr/lib/libdri2.so.0.0.0
b45c8000 b4616000 r-xp /usr/lib/libssl.so.1.0.0
b462b000 b4637000 r-xp /usr/lib/libeeze.so.1.13.0
b4648000 b4651000 r-xp /usr/lib/libethumb.so.1.13.0
b4661000 b4664000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4674000 b482b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5616000 b561f000 r-xp /usr/lib/libXi.so.6.1.0
b562f000 b5631000 r-xp /usr/lib/libXgesture.so.7.0.0
b5641000 b5645000 r-xp /usr/lib/libXtst.so.6.1.0
b5655000 b565b000 r-xp /usr/lib/libXrender.so.1.3.0
b566b000 b5671000 r-xp /usr/lib/libXrandr.so.2.2.0
b5681000 b5683000 r-xp /usr/lib/libXinerama.so.1.0.0
b5694000 b5697000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a7000 b56b2000 r-xp /usr/lib/libXext.so.6.4.0
b56c2000 b56c4000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d4000 b56d6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e6000 b57c8000 r-xp /usr/lib/libX11.so.6.3.0
b57dc000 b57e3000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f3000 b580b000 r-xp /usr/lib/libudev.so.1.6.0
b580d000 b5810000 r-xp /lib/libattr.so.1.1.0
b5820000 b5840000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5841000 b5846000 r-xp /usr/lib/libffi.so.6.0.2
b5857000 b586f000 r-xp /lib/libz.so.1.2.8
b587f000 b5881000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5891000 b5966000 r-xp /usr/lib/libxml2.so.2.9.2
b597b000 b5a16000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a32000 b5a35000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a45000 b5a5e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6f000 b5a80000 r-xp /lib/libresolv-2.20-2014.11.so
b5a94000 b5b0e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b23000 b5b25000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b35000 b5b3c000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4c000 b5b56000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b67000 b5b7f000 r-xp /usr/lib/libpng12.so.0.50.0
b5b90000 b5bb3000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd4000 b5be8000 r-xp /usr/lib/libector.so.1.13.0
b5bf9000 b5c11000 r-xp /usr/lib/liblua-5.1.so
b5c22000 b5c79000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8d000 b5cb5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc6000 b5cd9000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cea000 b5d24000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d35000 b5d43000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d53000 b5d5b000 r-xp /usr/lib/libtbm.so.1.0.0
b5d6b000 b5d78000 r-xp /usr/lib/libeio.so.1.13.0
b5d88000 b5d8a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d9a000 b5d9f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5daf000 b5dc6000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd8000 b5df8000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e08000 b5e28000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e2a000 b5e30000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e40000 b5e51000 r-xp /usr/lib/libemotion.so.1.13.0
b5e62000 b5e69000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e79000 b5e88000 r-xp /usr/lib/libeo.so.1.13.0
b5e99000 b5eab000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ebc000 b5ec1000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed1000 b5eea000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5efa000 b5f17000 r-xp /usr/lib/libeet.so.1.13.0
b5f30000 b5f78000 r-xp /usr/lib/libeina.so.1.13.0
b5f89000 b5f99000 r-xp /usr/lib/libefl.so.1.13.0
b5faa000 b608f000 r-xp /usr/lib/libicuuc.so.51.1
b60ac000 b61ec000 r-xp /usr/lib/libicui18n.so.51.1
b6203000 b623b000 r-xp /usr/lib/libecore_x.so.1.13.0
b624d000 b6250000 r-xp /lib/libcap.so.2.21
b6260000 b6289000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b629a000 b62a1000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62b3000 b62ea000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62fb000 b63e6000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63f9000 b6472000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6484000 b6489000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6499000 b64a3000 r-xp /usr/lib/libvconf.so.0.2.45
b64b3000 b64b5000 r-xp /usr/lib/libvasum.so.0.3.1
b64c5000 b64c7000 r-xp /usr/lib/libttrace.so.1.1
b64d7000 b64da000 r-xp /usr/lib/libiniparser.so.0
b64ea000 b6510000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6520000 b6525000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6536000 b654d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b655e000 b65c9000 r-xp /lib/libm-2.20-2014.11.so
b65da000 b65e0000 r-xp /lib/librt-2.20-2014.11.so
b65f1000 b65fe000 r-xp /usr/lib/libunwind.so.8.0.1
b6634000 b6758000 r-xp /lib/libc-2.20-2014.11.so
b676d000 b6786000 r-xp /lib/libgcc_s-4.9.so.1
b6796000 b6878000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6889000 b68b3000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c4000 b6900000 r-xp /usr/lib/libsystemd.so.0.4.0
b6902000 b6985000 r-xp /usr/lib/libedje.so.1.13.0
b6998000 b69b6000 r-xp /usr/lib/libecore.so.1.13.0
b69d6000 b6b5d000 r-xp /usr/lib/libevas.so.1.13.0
b6b92000 b6ba6000 r-xp /lib/libpthread-2.20-2014.11.so
b6bba000 b6dee000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1d000 b6e21000 r-xp /usr/lib/libsmack.so.1.0.0
b6e31000 b6e38000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e48000 b6e4a000 r-xp /usr/lib/libdlog.so.0.0.0
b6e5a000 b6e5d000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6d000 b6e6f000 r-xp /lib/libdl-2.20-2014.11.so
b6e80000 b6e98000 r-xp /usr/lib/libaul.so.0.1.0
b6eac000 b6eb1000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ec2000 b6ecf000 r-xp /usr/lib/liblptcp.so
b6ee1000 b6ee5000 r-xp /usr/lib/libsys-assert.so
b6ef6000 b6f16000 r-xp /lib/ld-2.20-2014.11.so
b6f27000 b6f2c000 r-xp /usr/bin/launchpad-loader
b793a000 b7b7f000 rw-p [heap]
bee52000 bee73000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16621)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb278864e) [/opt/usr/apps/org.example.client/bin/client] + 0x564e
 1: _ZN7MyLoginC2EP9Naviframe + 0x84 (0xb27885d5) [/opt/usr/apps/org.example.client/bin/client] + 0x55d5
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb27883a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb27a15cf) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5cf
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb27a1745) [/opt/usr/apps/org.example.client/bin/client] + 0x1e745
 5: (0xb3f654f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6eaf203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3f65909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27a1acf) [/opt/usr/apps/org.example.client/bin/client] + 0x1eacf
 9: main + 0x40 (0xb2788129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6f28bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb664a4bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f28eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
message(972) > port exist check !!
06-13 14:04:21.442+0900 I/MESSAGE_PORT(16944): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 14:04:21.442+0900 I/MESSAGE_PORT(16944): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 14:04:21.442+0900 I/MESSAGE_PORT(16944): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:04:21.452+0900 I/MESSAGE_PORT(16944): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:04:21.452+0900 I/MESSAGE_PORT(16944): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:04:21.452+0900 I/MESSAGE_PORT(16944): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:04:21.452+0900 I/MESSAGE_PORT(16944): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:04:21.452+0900 I/MESSAGE_PORT(16944): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 14:04:21.452+0900 I/MESSAGE_PORT(16944): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 14:04:21.452+0900 I/MESSAGE_PORT(16944): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:04:21.452+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:04:21.452+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:21.452+0900 E/MESSAGE_PORT(16944): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 14:04:21.452+0900 E/weather-common(16944): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 14:04:21.452+0900 E/weather-agent(16944): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 14:04:21.452+0900 E/weather-agent(16944): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 14:04:21.472+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:04:21.472+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:04:21.472+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:21.482+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:21.482+0900 I/MESSAGE_PORT(16944): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:04:21.482+0900 I/MESSAGE_PORT(16944): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:04:21.512+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:04:21.512+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:04:21.512+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:21.512+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:21.512+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:21.512+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:04:21.512+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 14:04:21.562+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:04:21.562+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:04:21.582+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:04:21.592+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:21.602+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
06-13 14:04:21.602+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
06-13 14:04:21.602+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 14:04:21.602+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
06-13 14:04:21.602+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [visible]
06-13 14:04:21.602+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
06-13 14:04:21.602+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
06-13 14:04:21.602+0900 W/INDICATOR(  665): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-13 14:04:21.602+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
06-13 14:04:21.602+0900 W/APP_CORE(  857): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
06-13 14:04:21.602+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 14:04:21.602+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:04:21.612+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
06-13 14:04:21.612+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
06-13 14:04:21.612+0900 W/INDICATOR(  665): main.c: _indicator_lock_status_cb(413) > Hide Clock
06-13 14:04:21.792+0900 E/PKGMGR_SERVER(16937): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:04:22.463+0900 E/weather-agent(16944): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:04:22.463+0900 I/CAPI_APPFW_APPLICATION(16944): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:04:22.463+0900 E/weather-agent(16944): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:04:22.463+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:04:22.463+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:04:22.583+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:04:22.583+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16944
06-13 14:04:22.583+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[16944] terminate event is forwarded
06-13 14:04:22.583+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:04:22.583+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 16944, ]
06-13 14:04:22.583+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:04:22.583+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:04:22.583+0900 I/Tizen::App( 1175): (512) > Not registered pid(16944)
06-13 14:04:22.583+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:04:22.583+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:04:22.583+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16944
06-13 14:04:22.593+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:04:22.593+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 16944.
06-13 14:04:22.593+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
06-13 14:04:22.763+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:04:22.763+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:04:22.763+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:04:22.763+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:04:22.763+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:04:22.763+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:04:22.773+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:04:22.773+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:04:22.773+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:04:22.793+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:04:22.793+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:04:22.793+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:04:22.793+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:04:22.793+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:04:22.793+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:04:22.793+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:04:22.803+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:04:22.803+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:04:22.803+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:04:22.803+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:04:22.813+0900 E/PKGMGR_SERVER(16937): pkgmgr-server.c: sighandler(417) > child NORMAL exit [16940]
06-13 14:04:22.813+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:04:22.813+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:04:22.813+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:04:22.813+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:04:22.813+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:04:22.813+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:04:22.813+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-13 14:04:22.823+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:04:22.823+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:04:22.823+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:04:22.823+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:04:22.823+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:04:22.833+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:04:22.833+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:04:22.923+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-13 14:04:22.923+0900 W/LOCKSCREEN(  857): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-13 14:04:22.923+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-13 14:04:22.923+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-13 14:04:22.923+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-13 14:04:22.923+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-13 14:04:22.923+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 14:04:22.933+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 2:04
06-13 14:04:22.933+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 2:04"
06-13 14:04:22.933+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 2:04"
06-13 14:04:22.933+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 14:04:22.933+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146916195 Time: <font_size=31> </font_size> <font_size=31> 오후 2:04</font_size></font>"
06-13 14:04:22.933+0900 I/INDICATOR(  665): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
06-13 14:04:22.933+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-13 14:04:22.933+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:04:22.933+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:04:22.933+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:04:22.933+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:04:22.933+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:04:22.933+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:04:22.933+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:04:22.933+0900 E/LOCKSCREEN(  857): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-13 14:04:23.163+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-13 14:04:23.163+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-13 14:04:23.163+0900 W/APP_CORE(  857): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-13 14:04:23.163+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: RESUME State: PAUSED
06-13 14:04:23.163+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:04:23.163+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-13 14:04:23.163+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-13 14:04:23.163+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:04:23.163+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-13 14:04:23.163+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:04:23.163+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 857
06-13 14:04:23.163+0900 I/AUL_AMD (  607): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-13 14:04:23.183+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 16955
06-13 14:04:23.183+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:04:23.234+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 16955
06-13 14:04:23.234+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16955, appid: com.samsung.weather-m-agent
06-13 14:04:23.244+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-13 14:04:23.244+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 16955.
06-13 14:04:23.244+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16955)
06-13 14:04:23.404+0900 E/weather-agent(16955): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-13 14:04:23.404+0900 E/weather-common(16955): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-13 14:04:23.404+0900 E/weather-agent(16955): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-13 14:04:23.404+0900 E/weather-common(16955): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-13 14:04:23.404+0900 E/weather-common(16955): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-13 14:04:23.404+0900 E/weather-common(16955): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-13 14:04:23.404+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-13 14:04:23.404+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-13 14:04:23.404+0900 I/MESSAGE_PORT(16955): message-port.c: __initialize(872) > initialize
06-13 14:04:23.414+0900 I/MESSAGE_PORT(16955): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-13 14:04:23.444+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:04:23.444+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:04:23.444+0900 I/MESSAGE_PORT(16955): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:04:23.444+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-13 14:04:23.444+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-13 14:04:23.444+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:04:23.444+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:04:23.444+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-13 14:04:23.454+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:04:23.454+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:23.454+0900 E/MESSAGE_PORT(16955): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-13 14:04:23.454+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 14:04:23.454+0900 I/MESSAGE_PORT(16955): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:04:23.454+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:04:23.464+0900 E/MESSAGE_PORT(16955): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 14:04:23.464+0900 E/weather-common(16955): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 14:04:23.464+0900 E/weather-agent(16955): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 14:04:23.464+0900 E/weather-agent(16955): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 14:04:23.464+0900 I/MESSAGE_PORT(16955): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:04:23.464+0900 I/MESSAGE_PORT(16955): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:04:23.464+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:23.484+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:23.524+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:04:23.524+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:04:23.524+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:23.524+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:23.524+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:23.524+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:04:23.534+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 14:04:23.564+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 14:04:23.564+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:04:23.584+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:04:23.604+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-13 14:04:23.604+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:04:23.614+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:04:23.614+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:04:23.614+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17249828
06-13 14:04:23.624+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:04:23.624+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:04:23.624+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:23.624+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:23.624+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:23.624+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:04:23.634+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:04:23.634+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:04:23.634+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:04:23.634+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:04:23.634+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:04:23.694+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:04:23.704+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:04:23.714+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17249928
06-13 14:04:23.724+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-13 14:04:23.724+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-13 14:04:23.724+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:04:23.794+0900 E/PKGMGR_SERVER(16937): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:04:23.794+0900 E/PKGMGR_SERVER(16937): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:04:24.054+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-13 14:04:24.054+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-13 14:04:24.054+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-13 14:04:24.054+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 14:04:24.054+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:04:24.054+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:04:24.054+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:04:24.054+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:04:24.054+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:04:24.064+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:04:24.074+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-13 14:04:24.074+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-13 14:04:24.074+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-13 14:04:24.074+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:04:24.074+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:04:24.074+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:04:24.074+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:04:24.074+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(857) status(4)
06-13 14:04:24.074+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(857)
06-13 14:04:24.074+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 857, appid: com.samsung.lockscreen, status: bg
06-13 14:04:24.084+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:04:24.084+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:04:24.084+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:04:24.084+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:04:24.084+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:04:24.094+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-13 14:04:24.094+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: PAUSE State: RUNNING
06-13 14:04:24.094+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:04:24.094+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:04:24.094+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:04:24.094+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-13 14:04:24.094+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-13 14:04:24.094+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:04:24.094+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 14:04:24.104+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:04:24.104+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:04:24.114+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:04:24.114+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:04:24.114+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:04:24.194+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-13 14:04:24.194+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:04:24.194+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:04:24.194+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:04:24.194+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:04:24.204+0900 E/LOCKSCREEN(  857): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-13 14:04:24.465+0900 E/weather-agent(16955): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:04:24.465+0900 I/CAPI_APPFW_APPLICATION(16955): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:04:24.465+0900 E/weather-agent(16955): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:04:24.465+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:04:24.465+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:04:24.595+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:04:24.595+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16955
06-13 14:04:24.605+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[16955] terminate event is forwarded
06-13 14:04:24.605+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:04:24.605+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 16955, ]
06-13 14:04:24.605+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:04:24.605+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:04:24.605+0900 I/Tizen::App( 1175): (512) > Not registered pid(16955)
06-13 14:04:24.605+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:04:24.605+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:04:24.605+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16955
06-13 14:04:24.605+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:04:24.605+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 16955.
06-13 14:04:27.117+0900 W/AUL     (17014): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:04:27.117+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:04:27.127+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:04:27.127+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:04:27.127+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:04:27.127+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 17014
06-13 14:04:27.127+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:04:27.137+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:04:27.137+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:04:27.137+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:04:27.147+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:04:27.147+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:04:27.157+0900 I/abc     (16621): abc
06-13 14:04:27.157+0900 I/CAPI_APPFW_APPLICATION(16621): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:04:27.157+0900 I/CAPI_APPFW_APPLICATION(16621): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:04:27.187+0900 E/TBM     (16621): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:04:27.247+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16621, appid: org.example.client
06-13 14:04:27.247+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:04:27.247+0900 W/AUL     (17014): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16621)
06-13 14:04:27.468+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:04:27.648+0900 W/CRASH_MANAGER(17029): worker.c: worker_job(1199) > 0416621636c69149733026
